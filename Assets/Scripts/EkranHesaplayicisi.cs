using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi 
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    //De�erlere d��ardan Ula�mak i�in Public metot olu�turduk
    /// <summary>
    /// Ekran�n Sol kenar�n� hesaplar.
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }
    /// <summary>
    /// Ekran�n Sa� kenar�n� hesaplar.
    /// </summary>
    public static float Sag
    {
        get
        {
            return sag;
        }
    }
    /// <summary>
    /// Ekran�n �st kenar�n� hesaplar.
    /// </summary>
    public static float Ust
    {
        get
        {
            return ust;
        }
    }
    /// <summary>
    /// Ekran�n Alt kenar�n� hesaplar.
    /// </summary>
    public static float Alt
    {
        get
        {
            return alt;
        }
    }

    //Bu de�i�kenleri �a��rmak-atamak i�in bi  metot yapmam�z laz�m ismi(Initialize k�saca Init)

    public static void Init()
    {
        float ekranZEkseni = -Camera.main.transform.position.z;
        //pixel olarak ekran de�erleri
        Vector3 solAltKose = new Vector3(0, 0, ekranZEkseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZEkseni);

        //�imdi bize bu de�erlerin oyun d�nyas� de�erleri laz�m onu daa camera.main.ScreenWorldPoint(...) ile
        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);

        //Daha sonra bu de�erleri en ba�ta "get" �ekilde yazd���m�z de�erlere atamal�y�z
        sol = solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;

    }



















   
}
