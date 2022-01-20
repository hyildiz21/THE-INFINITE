using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    //main cam den ulaþmak için objeleri tanýtýyoruz
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
        //Oyun baþlar baþlamaz (unity editör play tuþu) ekranda oyun bitti ve puan inaktif olsun.
        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);  
    }
    /// <summary>
    /// oyundaki play tusuna basýnca ekrandaki play tuþu ve oyun ismi inaktif olur.
    /// </summary>
    /// bunu çaðýrmak istiyorsak oyun kontrol scriptinde tanýmlayarak yapabiliriz class ismi* oyun baþlat metodunda
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
        //farklý asteroidlerin prefab isimlerindeki 8. harfe göre puan daðýlýmý yapýldý.
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
