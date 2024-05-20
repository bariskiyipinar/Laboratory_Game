using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampermetre : MonoBehaviour
{
    public GameObject AmpermetreUI;
    private bool isPanelActive = false;
    private bool isCursorLocked = false;
    void Start()
    {
        AmpermetreUI.SetActive(false);
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "ampermetre")
                {
                    if (!isPanelActive)
                    {
                        AmpermetreUI.SetActive(true); // Paneli aç
                        Time.timeScale = 0;
                        isPanelActive = true;
                        Cursor.lockState = CursorLockMode.Confined; // Fareyi sabitle
                        isCursorLocked = true;
                    }
                    else
                    {
                        AmpermetreUI.SetActive(false); // Paneli kapat

                        Time.timeScale = 1;
                        isPanelActive = false;
                        isCursorLocked = false;
                    }
                }
            }
        }
    }
}
