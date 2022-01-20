using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// uzay geminin max hýz limiti
    /// </summary>
    int maxHiz;
    /// <summary>
    /// geminin rengini belirler
    /// </summary>
    string renk;

    /// <summary>
    /// max hýz deðeri döner
    /// </summary>
    public int MaxHiz
    {
        get { return maxHiz; }
    }
    /// <summary>
    /// geminin rengini döner.
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }
    /// <summary>
    /// renk ve hizi yazýn
    /// </summary>
    /// <param name="maxHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maxHiz, string renk)
    {
        this.maxHiz = maxHiz;
        this.renk = renk;
    }
    //Eðer ki kullanýcý sadece hýz bilgisi girer ise o zaman bir tane daha CONSTRUCTOR yazalým

    public UzayGemisi(int maxHiz)
    {
        this.maxHiz = maxHiz;
    }
    /// <summary>
    /// uzay gemisini hýzlandýran süper güç
    /// </summary>
    public void Hizlandirici()
    {
        maxHiz += Random.Range(5, 20);
        Debug.Log(maxHiz);
    }
    /// <summary>
    /// uzay gemisini yavaþlatma
    /// </summary>
    public void Yavaslatici()
    {
        maxHiz -= Random.Range(5, 20);
        Debug.Log("Hýz: " + maxHiz);
    }


}
