using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
        }
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}