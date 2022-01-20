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
    /// geri say�m sayac�n�n toplam s�resini ayarlar
    /// </summary>
    public float ToplamSure //ToplamSure d��ardan de�er alaca�� i�in public �ekilde yazd�k??
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
    /// geri say�m�n bitti�ini s�yler
    /// </summary>
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }


    /// <summary>
    /// geri say�m� �al��t�r�r.
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
