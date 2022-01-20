using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefabs;

    OyunKontrol oyunKontrol;



    //asteroidlerin hareketi sa� a�ag�(+x,-y) ve sol a�a��(-x,-y)
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rbd2d = GetComponent<Rigidbody2D>();
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>(); //AsteroidYokOldu Metodunu kullanmak i�in bile�im ol�turduk 

        float yon = Random.Range(0f, 1f);
        if (yon < 0.5f)
        {
            //sol asa��
            rbd2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            //Asteroidlerin d�nmesini istiyoruz o y�zden Torque ekleyelim.
            rbd2d.AddTorque(yon * 4.0f);
        }
        else
        {
            //sa� a�a��
            rbd2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, 1.0f)), ForceMode2D.Impulse);
            //Asteroidlerin d�nmesini istiyoruz o y�zden Torque ekleyelim.
            rbd2d.AddTorque(-yon * 4.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kursun")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AsteroidPatlama();
            oyunKontrol.AsteroidYokOldu(gameObject);
            //Buradaki gameobject asteroid oluyo.
            AsteroidYokEt();

        }
    }
    //ayr� metoda almam�z�n sebebi oyun bitince ekrandaki asteroidlerinde yok olmas�n� istioz o y�zden bu metodu �a��raca��z oyun bitince
    public void AsteroidYokEt()
    {
        Instantiate(patlamaPrefabs, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
