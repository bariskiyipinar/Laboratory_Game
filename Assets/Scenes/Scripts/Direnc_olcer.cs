using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Direnc_olcer : MonoBehaviour
{
    public GameObject resim;
    private bool isPanelActive = false;
    private bool isCursorLocked = false;

    void Start()
    {
        resim.SetActive(false); // Paneli ba�lang��ta kapal� olarak ayarla
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "direnc")
                {
                    if (!isPanelActive)
                    {
                        resim.SetActive(true); // Paneli a�
                        Time.timeScale = 0;
                        isPanelActive = true;
                        Cursor.lockState = CursorLockMode.Confined; // Fareyi sabitle
                        isCursorLocked = true;
                    }
                    else
                    {
                        resim.SetActive(false); // Paneli kapat
               
                        Time.timeScale = 1;
                        isPanelActive = false;
                        isCursorLocked = false;
                    }
                }
                //else if (isPanelActive) // Panel a��ksa ve panelin d���na t�kland�ysa
                //{
                //    resim.SetActive(false); // Paneli kapat
                 
                //    Time.timeScale = 1;
                //    isPanelActive = false;
                //    isCursorLocked = false;
                //}
            }
        }

        //if (isCursorLocked)
        //{
        //    // Fare d�nd�r�l�yorsa paneli kapat
        //    if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        //    {
        //        resim.SetActive(true);
        //        isPanelActive = false;
        //    }
        //}
    }

   
}
