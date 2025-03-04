using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip menuMusic;
    private AudioSource audioSource;

    private static MusicManager instance; // Para mantener una sola instancia.

    void Awake()
    {
        // Si ya existe una instancia del MusicManager, destruimos este objeto.
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // De lo contrario, esta instancia se convierte en la única.
        instance = this;
        DontDestroyOnLoad(gameObject);

        // Configuramos el AudioSource.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Start()
    {
        PlayMusic(menuMusic);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void PlayMusic(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.loop = true;
            audioSource.Play(); // Reinicia la música al cambiar de escena.
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayMusic(menuMusic); // Reproduce el tema desde el principio al cargar la nueva escena.
    }
}