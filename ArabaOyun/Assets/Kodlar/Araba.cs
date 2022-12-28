using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Araba : MonoBehaviour
{
    float horizontal;
    Rigidbody2D rigid;
    public float ArabaHiz;
    int puan;
    public Text PuanText;
    Vector3 Fark;
    public GameObject Kamera;
    Vector3 Toplam;
    float floatZaman;

    void Start()
    {
        rigid =  GetComponent<Rigidbody2D>();
        Fark = Kamera.transform.position -transform.position;

    }
    void Update()
    {
        ArabaHaraketEt();
        PuanText.text = "Puan : " + puan.ToString();

        Toplam = transform.position + Fark;
        Kamera.transform.position = new Vector3(Toplam.x , Toplam.y , Kamera.transform.position.z);
    }
    void ArabaHaraketEt()
    {
        horizontal = Input.GetAxis("Horizontal");
        rigid.AddForce(new Vector3(horizontal*ArabaHiz,0,0));
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            puan++;
            Destroy(collision.gameObject);
        }
        

    }

}
 