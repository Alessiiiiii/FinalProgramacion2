using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonVolverAJugar : MonoBehaviour
{
    public void VolverAJugar()
    {
        SceneManager.LoadScene(1);
    }
}

