using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Ampermetre1 : MonoBehaviour
{
    public TextMeshProUGUI gerilim;
    public TextMeshProUGUI direnc;
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI SonucTxt;
    void Start()
    {
        
    }

    public void Test()
    {
        float deger1, deger2;

        if (float.TryParse(input1.text, out deger1) && float.TryParse(input2.text, out deger2))
        {
            float sonuc = deger1 / deger2;
            SonucTxt.text = "Sonuç :" + sonuc.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
