using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public Text UserInput;
    public GameObject Huevito;
    GameObject clonHuevo;
    int counter = 0;
    public Text CantCreados;

    public void Start()
    {
        CantCreados.text = "";
    }


    public void GenerarNClones() //Esta funcion es para crear cantidad de clones definida por el input field
    {   
        int cantHuevos = int.Parse(UserInput.text);
        for (int i = 0; i < cantHuevos; i++)
        {
            GameObject clon = Instantiate(Huevito);
            Destroy(clon, 2);
        }
    }

    public void contarCLones() //Esta funcion spawnea un clon y muestra la cantidad spawneada en un texto
    {
        GameObject clon = Instantiate(Huevito);
        Destroy(clon, 2);
        counter++;
        CantCreados.text = "Creaste " + counter + " clones";
    }


}
