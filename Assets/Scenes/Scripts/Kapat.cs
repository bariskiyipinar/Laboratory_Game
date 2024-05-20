using UnityEngine;

public class Kapat : MonoBehaviour
{
    public GameObject Resim;
    public direnc_olcer1 resistanceTester;
    public GameObject VoltmetreUI;
    public GameObject AmpermetreUI;
   

    private void Start()
    {
        // "Resim" objesinin etkinli�ini ba�lang��ta true olarak ayarla
        Resim.SetActive(true);
    }

    public void Kapatfonk()
    {
        // "Resim" objesinin etkinli�ini kapat
        Resim.SetActive(false);

        // Zaman �l�e�ini 1.0f'ye geri ayarla
        Time.timeScale = 1.0f;

        // "resistanceTester" nesnesine eri�erek t�m diren� �l��m i�lemlerini s�f�rla
        if (resistanceTester != null)
        {
            resistanceTester.ResetResistanceTest();
        }
    }
    public void KapatFonk()
    {
        VoltmetreUI.SetActive(false);
        Time.timeScale = 1f;

       
    }

    public void KapatFonk2()
    {
        AmpermetreUI.SetActive(false);
        Time.timeScale = 1f;


    }
}
