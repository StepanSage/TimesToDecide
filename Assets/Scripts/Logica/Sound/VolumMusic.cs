using UnityEngine;
using UnityEngine.UI;

public class VolumMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Sprite _offMusic;
    [SerializeField] private Sprite _onMusic;
    [SerializeField] private Image _button;
    [SerializeField] private ButtonClek _buttonClek;
    public float volume { get; private set; }

    private void Start()
    {
        string GetBool = PlayerPrefs.GetString("MusicSeting");
        bool TempBool = bool.Parse(GetBool);

        if(TempBool == true)
        {
            ONMusic();
        }
        else
        {
            OFFMusic();
        }
    }

    public void OFFMusic()
    {
        _audioSource.volume = 0f;
        volume = _audioSource.volume;
        _button.sprite = _offMusic;
    }

    public void ONMusic()
    {
        _audioSource.volume = 0.5f;
        volume = _audioSource.volume;
        _button.sprite = _onMusic;
    }
}
