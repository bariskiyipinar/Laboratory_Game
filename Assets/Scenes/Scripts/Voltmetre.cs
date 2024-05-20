using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voltmetre : MonoBehaviour
{

    public GameObject VoltmetreUI;
    private bool isPanelActive = false;
    private bool isCursorLocked = false;
    void Start()
    {
        VoltmetreUI.SetActive(false);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "voltmetre")
                {
                    if (!isPanelActive)
                    {
                        VoltmetreUI.SetActive(true); // Paneli aç
                        Time.timeScale = 0;
                        isPanelActive = true;
                        Cursor.lockState = CursorLockMode.Confined; // Fareyi sabitle
                        isCursorLocked = true;
                    }
                    else
                    {
                        VoltmetreUI.SetActive(false); // Paneli kapat

                        Time.timeScale = 1;
                        isPanelActive = false;
                        isCursorLocked = false;
                    }
                }
            }
        }
    }
}
