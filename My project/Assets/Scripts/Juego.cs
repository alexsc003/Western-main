using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Juego : MonoBehaviour
{
    [SerializeField]
    GameObject juegoEnActivo;
    [SerializeField]
    TextMeshProUGUI tiempoTexto;
    [SerializeField]
    TextMeshProUGUI puntuacionTexto;
    [SerializeField]
    TextMeshProUGUI puntuacionfinalTexto;
    [SerializeField]
    GameObject[] arrayPersonajes;
    [SerializeField]
    GameObject popUpInicio;
    [SerializeField]
    GameObject popUpResultados;
    [SerializeField]
    float[] puntos;
    [SerializeField]
    GameObject[] posiciones;
    
    
    float tiempo = 60;
    float puntuacion;
    int i;
    float o;

    float respawn;

    void Update()
    {
        if (juegoEnActivo.activeSelf)
        {
            i = Random.Range(0, 5);
            respawn = respawn + Time.deltaTime;
            tiempo = tiempo - Time.deltaTime;
            tiempoTexto.text = tiempo.ToString("00");
            puntuacionTexto.text = puntuacion.ToString("000") + "S";
            if (respawn >= 5)
            {
                if (arrayPersonajes[i].activeSelf)
                    Debug.Log("Ya Creado");
                else
                    arrayPersonajes[i].SetActive(true);
                    respawn = 0;
            }
        }
    }
            public void Disparar()
            {
                {
                    puntuacion = puntuacion + puntos[i];
                    arrayPersonajes[i].SetActive(false);
                }
            }
            public void Empezar()
            {
                puntuacion = 0;
                tiempo = 60;
                juegoEnActivo.SetActive(true);
                popUpInicio.SetActive(false);
                popUpResultados.SetActive(false);
            }
            public void Sheriff()
            {
                i = 4;
            }
            public void Malo1()
            {
                i = 0;
            }
            public void Malo2()
            {
                i = 1;
            }
            public void Dama()
            {
                i = 3;
            }
            public void Civil()
            {
                i = 2;
            }
 }
    

