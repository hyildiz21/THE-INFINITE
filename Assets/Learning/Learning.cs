using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //constructorlar� kulland�k
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(20,50));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(20, 50), "Sar�");

        //gemi1.Hizlandirici();
        //gemi2.Hizlandirici();
        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        //hadi yar��t�ral�m
        if (gemi1.MaxHiz > gemi2.MaxHiz) //MaxHiz yazd���m�z propertyden gelen maxhiz de�eri
        {
            Debug.Log("Kazanan Gemi1.");
        }
        else if(gemi2.MaxHiz> gemi1.MaxHiz)
        {
            Debug.Log("Kazanan Gemi2.");
        }
        else
        {
            Debug.Log("Berabere.");
        }
        
        
        
        
        
        
        
        
        //int saldiranDusman = 10;
        //bool saldiriDevam = true;

        //while (saldiriDevam)
        //{
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Sald�r� devam ediyor, kalan d��man say�s�: " + saldiranDusman);
        //    saldiranDusman--;

        //}

        //do
        //{
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Sald�r� devam ediyor, kalan d��man say�s�: " + saldiranDusman);
        //    saldiranDusman--;

        //}
        //while (saldiriDevam);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
