using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _score; 
    public int _scoreAmmount { get; private set; }


    private void OnEnable() => SingleEvent.Score += CountScore;
    private void OnDisable() => SingleEvent.Score -= CountScore;

    private void CountScore()
    {
        _scoreAmmount++;
        _score.text = _scoreAmmount.ToString();
    }
    
}
