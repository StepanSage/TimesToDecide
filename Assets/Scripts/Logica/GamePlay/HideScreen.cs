using UnityEngine;

public class HideScreen : MonoBehaviour
{
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _canvasVariants;

    public void Hide()
    {
        _gameScreen.SetActive(false);
        _canvasVariants.SetActive(false);
    }

    public void Open()
    {
        _gameScreen.SetActive(true);
        _canvasVariants.SetActive(true);
    }
    
}
