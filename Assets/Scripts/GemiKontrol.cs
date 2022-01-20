using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab;

    [SerializeField]
    GameObject patlamaPrefab;

    OyunKontrol oyunKontrol;

    
    
    const float hareketgucu = 6;
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Uzay gemisinin hareketi 
        Vector3 position = transform.position;
        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical"); 

        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketgucu * Time.deltaTime;
        }
        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketgucu * Time.deltaTime;
        }
        transform.position=position;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunPozisyon = gameObject.transform.position;
            kursunPozisyon.y += 1;
            Instantiate(kursunPrefab, kursunPozisyon, Quaternion.identity);
        }



    }
    /// <summary>
    /// eðer ki herhangi bir asteroid uzay gemimize çarpar ise uzay gemisi yok olsun , ayný kurþunlarýn asteroidleri yok ettiði gibiyazdýk ama bu sefer collisionEnter2d
    /// </summary>
    /// <param name="coll"></param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag=="Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GemiPatlama();
            //eðer ki uzay gemisi asteroide çarpar ise oyun biter.
            oyunKontrol.OyunBitir();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
