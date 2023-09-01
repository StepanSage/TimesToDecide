using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckVariant : MonoBehaviour
{
    [SerializeField] private ChangeColor _changeColor;
    [SerializeField] private Save _save;
    [SerializeField] private AudioPlay _audioPlayWin;
    [SerializeField] private AudioPlay _audioPlayLose;
    [SerializeField] private Timer _timer;
    [SerializeField] private ClicGamePanel[] _clicGamePanel;
    [SerializeField] private GameObject _loseGamePanel;
    [SerializeField] private HideScreen _hideScreen;
  

    private Image mainImage;

    private void Awake()
    {
        mainImage= GetComponent<Image>();
    }

    private void Update()
    {
        if(_timer._currentTimes < 0)
        {
            _audioPlayLose.Play();
            StartCoroutine(BeetwenLose());
        }
    }
    public void Check(Image MyImage)
    {
        if (mainImage.color == MyImage.color )
        {
           _audioPlayWin.Play();
            StartCoroutine(BeetwenWin());
        }
        else
        {
            _audioPlayLose.Play();
            StartCoroutine(BeetwenLose());
        }
    }

    IEnumerator BeetwenWin()
    {
        yield return new WaitForSeconds(0.10f);
        SingleEvent.ActionScore();
        _changeColor.MainImageChange();
        SingleEvent.ActionTimer();
    }

    IEnumerator BeetwenLose()
    {
        yield return new WaitForSeconds(0.90f);
        _save.SaveDate();
        for (int i = 0; i < _clicGamePanel.Length; i++)
        {
            _clicGamePanel[i].enabled = false;
        }
        _hideScreen.Hide();
        _loseGamePanel.SetActive(true);
       
    }
}
