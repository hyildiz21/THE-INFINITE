using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayimSayaci geriSayimSayaci;

    // Start is called before the first frame update
    void Start()
    {
        //kursuna dikk kuvvet verdik
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        //Kursunu yok eder.
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// Eðer ki kurþunumuz herhangibir asteroidi yok ederse -tag ile kontrol ettik- kurþun kendisini de yok etsin.
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        } 
    }

}
