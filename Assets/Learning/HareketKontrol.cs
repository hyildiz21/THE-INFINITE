using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    float colliderEnYarim;
    float colliderBoyYarim;

    // Start is called before the first frame update
    void Start()
    {
        //oyun objesini rastgele bir kuvvetle Hareket etmeyi saðlar
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5,5)), ForceMode2D.Impulse);

        //BoxCollider Componennt lazým
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim = collider.size.x / 2;


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hasar Alýyorsun.");
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 position = Input.mousePosition; //Mouse um nerde?
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position); //Pixel deðerlerini oyun dünyasi deðerlerine
        //transform.position = position;
        //EkrandaKal();

    }
    void EkrandaKal()
    {
        Vector3 position = transform.position;
        if (position.x - colliderEnYarim < EkranHesaplayicisi.Sol)
        {
            position.x = EkranHesaplayicisi.Sol + colliderEnYarim;
        }
        else if (position.x + colliderEnYarim > EkranHesaplayicisi.Sag)
        {
            position.x = EkranHesaplayicisi.Sag - colliderEnYarim;
        }
        if (position.y + colliderBoyYarim > EkranHesaplayicisi.Ust)
        {
            position.y = EkranHesaplayicisi.Ust - colliderBoyYarim;
        }
        else if (position.y - colliderBoyYarim < EkranHesaplayicisi.Alt)
        {
            position.y = EkranHesaplayicisi.Alt + colliderBoyYarim;
        }


        transform.position = position;
    }

}
