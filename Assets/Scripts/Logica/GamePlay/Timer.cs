using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private ComplexityGames _complexityGames;
    
    public float _currentTimes {  get; private set; }
   

    private void OnEnable() => SingleEvent.Timer += Resettimer;
    private void OnDisable() => SingleEvent.Timer -= Resettimer;

    private void Start()
    {
        _currentTimes = _complexityGames.Complexity();
    }
    private void Update()
    {
       launchTimer();
    }

    public void launchTimer()
    {
        if(_currentTimes > 0) 
        {
            _currentTimes -= Time.deltaTime;
            _timerText.text = Mathf.Round(_currentTimes).ToString();
        }
       
    }

    public void Resettimer()
    {
        _currentTimes = _complexityGames.Complexity();
    }
}
