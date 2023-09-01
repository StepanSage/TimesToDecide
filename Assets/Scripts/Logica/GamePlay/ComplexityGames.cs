using UnityEngine;

public class ComplexityGames : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Score _score;

    private void Update()
    {
        Complexity();
    }
    public int Complexity()
    {
        if(_score._scoreAmmount <= 5)
        {
            return 5;
        }
        else if(_score._scoreAmmount <= 10 )
        {
            return 4;
        }
        else if (_score._scoreAmmount <= 20)
        {
            return 3;
        }
        else if (_score._scoreAmmount <= 35)
        {
            return 2;
        }
        else
        {
            return 1;
        }

       
    }
}
