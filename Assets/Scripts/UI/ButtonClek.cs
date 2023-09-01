using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClek : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _variant;
    [SerializeField] private GameObject _loadPanel;
    [SerializeField] private AudioPlay _audioPlay;
    [SerializeField] private ExitGames _exitGames;
    [SerializeField] private VolumMusic _volumMusic;
    [SerializeField] private Save _save;
    [SerializeField] private GameObject _clck;

    public bool switchers = true;

    private string _nameButton;
    private void Awake()
    {
        _nameButton = gameObject.name;
    }

    private void Start()
    {
        string GetBool = PlayerPrefs.GetString("MusicSeting");
        bool TempBool = bool.Parse(GetBool);
        switchers = TempBool;
       

    }
    private void OnMouseUpAsButton()
    {
        switch (_nameButton)
        {
            case "PlayGames":
                _audioPlay.Play();
                StartCoroutine(Loding());
                _save.saveMusicSetting();
                break;
            case "Ads":
                break;
            case "Heip":
                break;
            case "Music":         
                switchers = !switchers;
                _save.saveMusicSetting();
                if (switchers == true)
                {
                    _volumMusic.ONMusic();
                }
                else
                {
                    _volumMusic.OFFMusic();
                }
                break;
            case "Exit":
                _exitGames.Exit();
                break;
            case "ExitMenu":
                _audioPlay.Play();
                Time.timeScale = 1;
                StartCoroutine(Exit());
                break;
            case "ExitPanelMenu":
                _menuPanel.SetActive(false);
                _variant.SetActive(true);
                _audioPlay.Play();
                _clck.SetActive(true);
                break;
            case "OpenMenu":
               _clck.SetActive(false);
                _audioPlay.Play();
                _menuPanel.SetActive(true);
                _variant.SetActive(false);
                break;
            case "Restart":
                SceneManager.LoadScene(1);
                break;
        }
    }

    IEnumerator Loding()
    {
        _loadPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
    }

    IEnumerator Exit()
    {
        _loadPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        
    }

  

}
