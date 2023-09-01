using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private VolumMusic _volumMusic;
    [SerializeField] private ButtonClek _buttonClek;
    public  void SaveDate()
    {
       if(PlayerPrefs.GetInt("Score") < _score._scoreAmmount)
        PlayerPrefs.SetInt("Score", _score._scoreAmmount);
    }

    public void saveMusicSetting()
    {
        string SetBool = _buttonClek.switchers.ToString();
        PlayerPrefs.SetString("MusicSeting", SetBool);
       
              
    }
}
