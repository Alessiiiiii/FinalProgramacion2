using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemigoPatrulla : MonoBehaviour
{
    public Transform[] puntosPatrulla;
    public float velocidad = 2.0f;
    private int indiceActual = 0;

    void Start()
    {
        if (puntosPatrulla == null || puntosPatrulla.Length == 0)
        {
            Debug.LogError("No hay puntos de patrulla asignados.");
            return;
        }

        StartCoroutine(Patrullar());
    }

    IEnumerator Patrullar()
    {
        while (true)
        {
            Transform objetivo = puntosPatrulla[indiceActual];
            while (Vector3.Distance(transform.position, objetivo.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
                yield return null;
            }

            indiceActual = (indiceActual + 1) % puntosPatrulla.Length;
            yield return new WaitForSeconds(2.0f); // Espera antes de moverse al siguiente punto
        }
    }
}
