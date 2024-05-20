using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Voltmetre1 : MonoBehaviour
{
    public TextMeshProUGUI direnc;
    public TextMeshProUGUI akým;
    public TMP_InputField deger1;
    public TMP_InputField deger2;
    public TextMeshProUGUI sonucText;


    private float userResistance;
    void Start()
    {
        
    }
    public void testResistance()
    {
            float value1, value2;
        if (float.TryParse(deger1.text, out value1) && float.TryParse(deger2.text, out value2))
        {
            float result = value1 * value2;
            sonucText.text = "Sonuç :"+result.ToString();
        }

       

    }
    
    void Update()
    {
        
    }
}
