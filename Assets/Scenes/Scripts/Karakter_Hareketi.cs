using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter_Hareketi : MonoBehaviour
{
    public int hiz;
    public Rigidbody karakterziplamasi;
    public float ziplamagucu = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float yatayhareket = Input.GetAxis("Horizontal")*hiz;
        float dikeyhareket = Input.GetAxis("Vertical")*hiz;

        transform.Translate(dikeyhareket*Time.deltaTime,0f,yatayhareket*Time.deltaTime);
        
    }

   
}
