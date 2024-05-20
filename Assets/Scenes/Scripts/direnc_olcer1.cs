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
        // Oyun baþladýðýnda rastgele bir direnç deðeri seçilir (örneðin 10 ile 1000 arasýnda)
        //actualResistance = Random.Range(10, 1000);
        //resistanceText.text = "Gerçek Direnç Deðeri: " + actualResistance.ToString() + " Ohm";

        actualResistance = Random.Range(10, 1000);
        gercekdeger.text = "Gerçek Direnç Deðeri: " + actualResistance.ToString() + " Ohm";
    }

    public void TestResistance()
    {


        // Kullanýcýnýn girdiði direnç deðeri alýnýr
        float.TryParse(deger.text, out userResistance);

        // Kullanýcýnýn girdiði direnç deðeriyle gerçek direnç deðeri karþýlaþtýrýlýr
        if (userResistance == actualResistance)
        {
            sonuc.text = "Tebrikler! Doðru tahmin!";
        }
        else
        {
            sonuc.text = "Üzgünüm, yanlýþ tahmin. Gerçek deðer: " + actualResistance.ToString() + " Ohm";
        }
    }
    public void ResetResistanceTest()
    {
        actualResistance = Random.Range(10, 1000);
        gercekdeger.text = "Gerçek Direnç Deðeri: " + actualResistance.ToString() + " Ohm";
        sonuc.text = "";
        deger.text = "";
    }

}
