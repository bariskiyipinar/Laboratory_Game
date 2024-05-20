using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_Kontrol : MonoBehaviour
{
    Vector2 gecispos;
    Vector2 farepos;

    public float hassasiyet = 5.0f;
    public float yumusaklik = 2.0f;

    public float minVerticalAngle = -80f;
    public float maxVerticalAngle = 80f;

   

    GameObject oyuncu;

    void Start()
    {
        oyuncu = this.transform.parent.gameObject;
    }

    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
        gecispos.x = Mathf.Lerp(gecispos.x, md.x, 1f / yumusaklik);
        gecispos.y = Mathf.Lerp(gecispos.y, md.y, 1f / yumusaklik);

        farepos += gecispos;
        farepos.y = Mathf.Clamp(farepos.y, minVerticalAngle, maxVerticalAngle);
     

        transform.localRotation = Quaternion.AngleAxis(-farepos.y, Vector3.right);
        oyuncu.transform.localRotation = Quaternion.AngleAxis(farepos.x, oyuncu.transform.up);
    }
}
