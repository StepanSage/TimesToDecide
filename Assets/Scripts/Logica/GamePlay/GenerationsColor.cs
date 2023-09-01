using UnityEngine;


public class GenerationsColor : MonoBehaviour
{
    private Color[] _colorMass;
    private Color _tempColor;
    private Color _easyColor;
   
 
   public Vector4 EasyGeneretion()
   {
         _easyColor = Random.ColorHSV();
        var colorses = new Vector4(_easyColor.r, _easyColor.g, _easyColor.b, 1f);
        return colorses;
   }
  
    public Color[] MidGeneretion(Color BaseColor, int numberOfGenerations)
    {
        _colorMass = new Color[numberOfGenerations];
        for (int i = 0; i < numberOfGenerations; i++)
        {
            float red = Random.Range(0.1f, 0.3f);
            float blue = Random.Range(0.1f, 0.3f);
            float green = Random.Range(0.1f, 0.3f);

            float BaceColorR = BaseColor.r;
            float BaceColorG = BaseColor.g;
            float BaceColorB = BaseColor.b;

            if(BaceColorR - red >= 0 && BaceColorG - green >= 0 && BaceColorB - blue >=0)
            {
                _tempColor = new Vector4(BaceColorR - red, BaceColorG - green, BaceColorB - blue, 1f);
            }
            else
            {
                _tempColor = new Vector4(BaceColorR + red, BaceColorG + green, BaceColorB + blue, 1f);
            }
            _colorMass[i] = _tempColor;
        }
        return _colorMass;
    }

    
}
