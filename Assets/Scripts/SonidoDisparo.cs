using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    public AudioClip shootSound; // Arrastra aqu� el sonido del disparo en el Inspector.
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Detectamos el clic izquierdo del mouse para disparar.
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Opcional: Aqu� puedes agregar l�gica para destruir enemigos.
        PlayShootSound();
    }

    void PlayShootSound()
    {
        if (shootSound != null)
        {
            audioSource.PlayOneShot(shootSound); // Reproduce el sonido del disparo.
        }
    }
}