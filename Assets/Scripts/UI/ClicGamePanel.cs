using UnityEngine;
using UnityEngine.UI;

public class ClicGamePanel : MonoBehaviour
{
    [SerializeField] private string _nameButton;
    [SerializeField] private CheckVariant _checkVariant;      
    private void OnMouseUpAsButton()
    {
        switch (_nameButton)
        {
            case "1":
                Check();
                break;
            case "2":
                Check();
                break;
            case "3":
                Check();
                break;
            case "4":
                Check();
                break; 
        }
    }

    private void Check()
    {
        _checkVariant.Check(gameObject.GetComponent<Image>());
    }
   


}
