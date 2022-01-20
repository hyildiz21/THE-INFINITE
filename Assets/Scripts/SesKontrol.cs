using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidPatlama = default;

    [SerializeField]
    AudioClip ates = default;

    [SerializeField]
    AudioClip uzayGemisiPatlama = default;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AsteroidPatlama()
    {
        audioSource.PlayOneShot(asteroidPatlama, 0.1f);
    }

    public void GemiPatlama()
    {
        audioSource.PlayOneShot(uzayGemisiPatlama, 0.1f);
    }

    public void Ates()
    {
        audioSource.PlayOneShot(ates, 0.1f);
    }
}
