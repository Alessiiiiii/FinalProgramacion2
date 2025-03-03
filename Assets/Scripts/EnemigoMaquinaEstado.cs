using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemigoPersigue : MonoBehaviour

{
    private (float, float) posicion;
    private (float, float) objetivo;

    public EnemigoPersigue(float x, float y)
    {
        this.posicion = (x, y);
    }

    public void Actualizar((float, float) posicionObjetivo)
    {
        this.objetivo = posicionObjetivo;
        Perseguir();
    }

    private void Perseguir()
    {
        // Lógica para mover el enemigo hacia el objetivo
        float dx = objetivo.Item1 - posicion.Item1;
        float dy = objetivo.Item2 - posicion.Item2;
        float distancia = CalcularDistancia(posicion, objetivo);

        if (distancia > 0)
        {
            posicion.Item1 += dx / distancia;
            posicion.Item2 += dy / distancia;
        }

        Console.WriteLine("Posición actual: (" + posicion.Item1 + ", " + posicion.Item2 + ")");
    }

    private float CalcularDistancia((float, float) pos1, (float, float) pos2)
    {
        return (float)Math.Sqrt(Math.Pow(pos1.Item1 - pos2.Item1, 2) + Math.Pow(pos1.Item2 - pos2.Item2, 2));
    }
}

public class Program
{
    public static void Main()
    {
        EnemigoPersigue enemigo1 = new EnemigoPersigue(1, 2);
        (float, float) posicionObjetivo = (3, 4);

        while (true)
        {
            enemigo1.Actualizar(posicionObjetivo);

            System.Threading.Thread.Sleep(1000); // Espera 1 segundo entre actualizaciones
        }
    }
}
