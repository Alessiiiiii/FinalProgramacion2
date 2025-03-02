using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicaControlador : MonoBehaviour
{
    public GameObject panelGane;
    public int numEnemigos;
    
   
    // Start is called before the first frame update
    void Start()
    {
        numEnemigos=GameObject.FindGameObjectsWithTag("Enemigo").Length;
        panelGane.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestarEnemigos()
    {
        numEnemigos--;
        
        
        if (numEnemigos <= 0)

        {
            panelGane.SetActive(true);
        }
    }
        public void ReiniciarJuego()

        {
            SceneManager.LoadScene("SampleScene");
        }
    }

