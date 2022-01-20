using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{

    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroidList;

    GameObject hedefasteroid;
    GameObject uzayGemisi;

    // Start is called before the first frame update
    void Start()
    {
        //uzay geminin yerini belirler.
        uzayGemisi = GameObject.FindGameObjectWithTag("Player");
        asteroidList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //ASTEROÝDLERÝ EKRANDA VAR ETTÝK sol clickle
        //asteroidleri var eder.
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            //daha sonra asteroidleri listeye ekleyelim
            GameObject asteroid = Instantiate(asteroidPrefab, position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }

        //SAÐ CLICK ÝLE YOK EDELÝM ASTEREOÝDLERÝ
        //en yakýndakini yok etmemiz gerek

        if (Input.GetMouseButtonDown(1))
        {
            HedefiYokEt();
        }
    }

    GameObject EnYakinAsteroid()
    {
        
        GameObject enYakinAsteroid;
        float enYakinMesafe;

        if (asteroidList.Count == 0)
        {
            return null;
        }
        else
        {
            //EN YAKIN AST. ÝLK ELEMAN OLSUN 
            enYakinAsteroid = asteroidList[0];
            enYakinMesafe = MesafeOlcer(enYakinAsteroid);
        }

        foreach (GameObject asteroid in asteroidList)
        {
            float mesafe = MesafeOlcer(asteroid);
            if (mesafe < enYakinMesafe)
            {
                enYakinMesafe = mesafe;
                enYakinAsteroid = asteroid;

            }

        }
        return enYakinAsteroid;

    }

    public void HedefiYokEt()
    {
        hedefasteroid = EnYakinAsteroid();
        if (hedefasteroid != null)
        {
            hedefasteroid.GetComponent<YokEdici>().AsteroidYokEdici(1);
            asteroidList.Remove(hedefasteroid);
        }
    }

    float MesafeOlcer(GameObject hedef)
    {
        return Vector3.Distance(uzayGemisi.transform.position, hedef.transform.position);
    }
}
