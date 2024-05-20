using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class direnc_olcer1 : MonoBehaviour
{
    public TextMeshProUGUI gercekdeger;
    public TextMeshProUGUI sonuc;
    public TMP_InputField deger;

    private float actualResistance;
    private float userResistance;

    private void Start()
    {
        // Oyun ba�lad���nda rastgele bir diren� de�eri se�ilir (�rne�in 10 ile 1000 aras�nda)
        //actualResistance = Random.Range(10, 1000);
        //resistanceText.text = "Ger�ek Diren� De�eri: " + actualResistance.ToString() + " Ohm";

        actualResistance = Random.Range(10, 1000);
        gercekdeger.text = "Ger�ek Diren� De�eri: " + actualResistance.ToString() + " Ohm";
    }

    public void TestResistance()
    {


        // Kullan�c�n�n girdi�i diren� de�eri al�n�r
        float.TryParse(deger.text, out userResistance);

        // Kullan�c�n�n girdi�i diren� de�eriyle ger�ek diren� de�eri kar��la�t�r�l�r
        if (userResistance == actualResistance)
        {
            sonuc.text = "Tebrikler! Do�ru tahmin!";
        }
        else
        {
            sonuc.text = "�zg�n�m, yanl�� tahmin. Ger�ek de�er: " + actualResistance.ToString() + " Ohm";
        }
    }
    public void ResetResistanceTest()
    {
        actualResistance = Random.Range(10, 1000);
        gercekdeger.text = "Ger�ek Diren� De�eri: " + actualResistance.ToString() + " Ohm";
        sonuc.text = "";
        deger.text = "";
    }

}
