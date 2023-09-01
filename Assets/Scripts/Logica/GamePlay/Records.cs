using TMPro;
using UnityEngine;

public class Records : MonoBehaviour
{
    [SerializeField] TMP_Text _recordstext;
    void Start()
    {
        _recordstext.text = PlayerPrefs.GetInt("Score").ToString();
    }

   
}
