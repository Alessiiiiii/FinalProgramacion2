using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public TextMeshProUGUI textoTemporizador;
    public float tiempoRestante = 35f;
    public ContadorEnemigos contadorEnemigos;
    public int enemigosNecesarios = 8;
    private bool juegoTerminado = false;

    void Update()
    {
        if (juegoTerminado)
            return;

        tiempoRestante -= Time.deltaTime;
        textoTemporizador.text = "Tiempo: " + Mathf.Clamp(tiempoRestante, 0, tiempoRestante).ToString("F2");

        if (tiempoRestante <= 0)
        {
            ChequearEstadoJuego();
        }
    }

    void ChequearEstadoJuego()
    {
        if (contadorEnemigos.ObtenerEnemigosDestruidos() < enemigosNecesarios)
        {
            JuegoTerminado();
        }
    }

    void JuegoTerminado()
    {
        juegoTerminado = true;
        SceneManager.LoadScene("GameOver");
    }
}



