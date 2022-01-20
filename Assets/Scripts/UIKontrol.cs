using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    //main cam den ula�mak i�in objeleri tan�t�yoruz
    [SerializeField]
    GameObject oyunAdiText;

    [SerializeField]
    GameObject oyunBittiText;

    [SerializeField]
    Text puanText;

    [SerializeField]
    GameObject oynaButon;

    int puan;

    // Start is called before the first frame update
    void Start()
    {
        //Oyun ba�lar ba�lamaz (unity edit�r play tu�u) ekranda oyun bitti ve puan inaktif olsun.
        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);  
    }
    /// <summary>
    /// oyundaki play tusuna bas�nca ekrandaki play tu�u ve oyun ismi inaktif olur.
    /// </summary>
    /// bunu �a��rmak istiyorsak oyun kontrol scriptinde tan�mlayarak yapabiliriz class ismi* oyun ba�lat metodunda
    public void OyunBasladi()
    {
        puan = 0;
        oynaButon.gameObject.SetActive(false);
        oyunAdiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBittiText.gameObject.SetActive(false);
        PuanGuncelle();
    }

    public void OyunBitti()
    {
        oyunBittiText.gameObject.SetActive(true);
        oynaButon.gameObject.SetActive(true);
    }

    void PuanGuncelle()
    {
        puanText.text = "POINT: " + puan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AsteoidYokOldu(GameObject asteroid)
    {
        //farkl� asteroidlerin prefab isimlerindeki 8. harfe g�re puan da��l�m� yap�ld�.
        switch (asteroid.gameObject.name[8])
        {
            case '1': puan += 4; PuanGuncelle();
                break;
            case '2': puan += 8; PuanGuncelle();
                break;
            case '3': puan += 10; PuanGuncelle();
                break;
            default:
                break;
        }
    }
}
