using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorEnemigos : MonoBehaviour
{
    public Text textoContador;
    private int enemigosDestruidos = 0;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarContador();
    }
    public void IncrementarContador()
    {
        enemigosDestruidos++;
        ActualizarContador();
    }
    void ActualizarContador()
    {
        textoContador.text = "Enemigos destruidos  " + enemigosDestruidos.ToString();
    }

    public int ObtenerEnemigosDestruidos()
    
    {return enemigosDestruidos;

}

   
        
    }

