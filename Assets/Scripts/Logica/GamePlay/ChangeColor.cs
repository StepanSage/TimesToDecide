using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Color[] _currentColorsMass;
    private Color _baseColor;
    private GenerationsColor _coloresGeneration;

    [SerializeField] private Image _mainImage;
    [SerializeField] private Image[] imgMassPrefabs;

    private void Awake()
    {
        _coloresGeneration = new GenerationsColor();
    }

    void Start()
    {       
        MainImageChange();
    
    }

    public void MainImageChange()
    {
        _baseColor = _coloresGeneration.EasyGeneretion();
        _mainImage.color = _baseColor;
        ImageChange();

    }

    private void ImageChange()
    {
        int temp = Random.Range(0, imgMassPrefabs.Length);
        for (int i = 0; i < imgMassPrefabs.Length; i++)
        {
            _currentColorsMass = _coloresGeneration.MidGeneretion(_baseColor, imgMassPrefabs.Length);
            if (i != temp)
            {
                imgMassPrefabs[i].color = _currentColorsMass[i];
            }
            else
            {
                imgMassPrefabs[i].color = _baseColor;
                _currentColorsMass[i] = _baseColor;

            }
        }
    }

    
}
