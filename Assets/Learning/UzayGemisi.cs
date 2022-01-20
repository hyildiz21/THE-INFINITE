using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// uzay geminin max h�z limiti
    /// </summary>
    int maxHiz;
    /// <summary>
    /// geminin rengini belirler
    /// </summary>
    string renk;

    /// <summary>
    /// max h�z de�eri d�ner
    /// </summary>
    public int MaxHiz
    {
        get { return maxHiz; }
    }
    /// <summary>
    /// geminin rengini d�ner.
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }
    /// <summary>
    /// renk ve hizi yaz�n
    /// </summary>
    /// <param name="maxHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maxHiz, string renk)
    {
        this.maxHiz = maxHiz;
        this.renk = renk;
    }
    //E�er ki kullan�c� sadece h�z bilgisi girer ise o zaman bir tane daha CONSTRUCTOR yazal�m

    public UzayGemisi(int maxHiz)
    {
        this.maxHiz = maxHiz;
    }
    /// <summary>
    /// uzay gemisini h�zland�ran s�per g��
    /// </summary>
    public void Hizlandirici()
    {
        maxHiz += Random.Range(5, 20);
        Debug.Log(maxHiz);
    }
    /// <summary>
    /// uzay gemisini yava�latma
    /// </summary>
    public void Yavaslatici()
    {
        maxHiz -= Random.Range(5, 20);
        Debug.Log("H�z: " + maxHiz);
    }


}
