using UnityEngine;

public class Kapat : MonoBehaviour
{
    public GameObject Resim;
    public direnc_olcer1 resistanceTester;
    public GameObject VoltmetreUI;
    public GameObject AmpermetreUI;
   

    private void Start()
    {
        // "Resim" objesinin etkinliðini baþlangýçta true olarak ayarla
        Resim.SetActive(true);
    }

    public void Kapatfonk()
    {
        // "Resim" objesinin etkinliðini kapat
        Resim.SetActive(false);

        // Zaman ölçeðini 1.0f'ye geri ayarla
        Time.timeScale = 1.0f;

        // "resistanceTester" nesnesine eriþerek tüm direnç ölçüm iþlemlerini sýfýrla
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
