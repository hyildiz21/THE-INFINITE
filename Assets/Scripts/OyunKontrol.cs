using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject uzaygemisiPrefab;

    List<GameObject> asteroidList = new List<GameObject>();

    /// <summary>
    /// ka� t�r asteroid prefabine sahip oldu�unu g�stermek i�in 15 20 olsa bu tarz
    /// </summary>
    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();

    GameObject uzayGemisi;
    [SerializeField]
    int zorluk = 1;

    [SerializeField]
    int carpan = 5;

    UIKontrol uikontrol;
    // Start is called before the first frame update
    void Start()
    {
        uikontrol = GetComponent<UIKontrol>();
    }

    public void OyunuBaslat()
    {
        uikontrol.OyunBasladi();
        uzayGemisi = Instantiate(uzaygemisiPrefab);
        uzayGemisi.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f);
        AsteroidUret(7);
    }

    // Update is called once per frame
    

    //Asteroidler belirli bi say�n�n alt�na d��t�k�e yeni ast. ler var edilecek -oyun kurgusu-
    void AsteroidUret(int adet)
    {
        Vector3 position= new Vector3();

        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(EkranHesaplayicisi.Sol, EkranHesaplayicisi.Sag);
            position.y = EkranHesaplayicisi.Ust - 1;

            //�imdi bunu de�i�kene atay�p var edelim ve 3 farkl� ast.prefab oldu�u i�in herhangi birini var etsin
            GameObject asteroid= Instantiate(asteroidPrefabs[Random.Range(0,3)], position, Quaternion.identity);

            //Bizim ekranda ka� tane asteroid oldugunu bilmemiz gerek o y�zden ast.list
            asteroidList.Add(asteroid);

        }
    }

    public void AsteroidYokOldu(GameObject asteroid)
    {
        uikontrol.AsteoidYokOldu(asteroid);
        asteroidList.Remove(asteroid);
        Debug.Log("Kalan asteroid say�s�: " + asteroidList.Count);
        if (asteroidList.Count <= zorluk)
        {
            zorluk++; 
            AsteroidUret(zorluk * carpan);
        }

    }

    public void OyunBitir()
    {
        foreach (GameObject asteroid in asteroidList)
        {
            asteroid.GetComponent<Asteroid>().AsteroidYokEt();

        }
        zorluk = 1;
        asteroidList.Clear();
        uikontrol.OyunBitti();
    }




}
