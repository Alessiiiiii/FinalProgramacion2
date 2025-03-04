using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public GameObject efecto;
    public LogicaControlador logicaControlador;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        
        Instantiate(efecto,transform.position, Quaternion.identity);
        logicaControlador.RestarEnemigos();
        Destroy(gameObject);
    }
    public ContadorEnemigos contadorEnemigos;

    void OnDestroy()
    {
        if (contadorEnemigos != null)
        {
            contadorEnemigos.IncrementarContador();
        }
    }

}
