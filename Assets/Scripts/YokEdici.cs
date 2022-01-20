using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject yokediciprefabs;

    GeriSayimSayaci yokEdiciPatlama;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciPatlama = gameObject.AddComponent<GeriSayimSayaci>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciPatlama.Bitti)
        {
            Instantiate(yokediciprefabs, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);           
        }
    }
    /// <summary>
    /// oyun objesinin ne zaman yok olacaðýný biz söyleyeceðiz
    /// </summary>
    /// <param name="sure"></param>
    public void AsteroidYokEdici(int sure)
    {
        yokEdiciPatlama.ToplamSure = sure;
        yokEdiciPatlama.Calistir();
    }
}
