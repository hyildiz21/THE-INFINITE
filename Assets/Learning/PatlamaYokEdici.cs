using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{

    GeriSayimSayaci geriSayimSayaci;

    
    //PATLAMANIN B�TT���N� B�LMEM�Z GEREK


    // Start is called before the first frame update
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
       
        geriSayimSayaci.ToplamSure = 1;
        geriSayimSayaci.Calistir();

    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
           
            Destroy(gameObject);

        }
    }
}
