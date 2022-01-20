using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi 
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    //Deðerlere dýþardan Ulaþmak için Public metot oluþturduk
    /// <summary>
    /// Ekranýn Sol kenarýný hesaplar.
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }
    /// <summary>
    /// Ekranýn Sað kenarýný hesaplar.
    /// </summary>
    public static float Sag
    {
        get
        {
            return sag;
        }
    }
    /// <summary>
    /// Ekranýn Üst kenarýný hesaplar.
    /// </summary>
    public static float Ust
    {
        get
        {
            return ust;
        }
    }
    /// <summary>
    /// Ekranýn Alt kenarýný hesaplar.
    /// </summary>
    public static float Alt
    {
        get
        {
            return alt;
        }
    }

    //Bu deðiþkenleri çaðýrmak-atamak için bi  metot yapmamýz lazým ismi(Initialize kýsaca Init)

    public static void Init()
    {
        float ekranZEkseni = -Camera.main.transform.position.z;
        //pixel olarak ekran deðerleri
        Vector3 solAltKose = new Vector3(0, 0, ekranZEkseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZEkseni);

        //þimdi bize bu deðerlerin oyun dünyasý deðerleri lazým onu daa camera.main.ScreenWorldPoint(...) ile
        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);

        //Daha sonra bu deðerleri en baþta "get" þekilde yazdýðýmýz deðerlere atamalýyýz
        sol = solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;

    }



















   
}
