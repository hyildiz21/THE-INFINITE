using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimSayaci : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;

    bool calisiyor = false;
    bool basladi = false;

    /// <summary>
    /// geri sayým sayacýnýn toplam süresini ayarlar
    /// </summary>
    public float ToplamSure //ToplamSure dýþardan deðer alacaðý için public þekilde yazdýk??
    {
        set
        {
            if (!calisiyor)
            {
                toplamSure = value;
                
            }
        }
    }
    /// <summary>
    /// geri sayýmýn bittiðini söyler
    /// </summary>
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }


    /// <summary>
    /// geri sayýmý çalýþtýrýr.
    /// </summary>
    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisiyor = true;
            basladi = true;
            gecenSure = 0;

        }
    }

    
  
    // Update is called once per frame
    void Update()
    {
        //neyi kontrol ediyoz
        if (calisiyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
            {
                calisiyor = false;
            }
        }

    }
}
