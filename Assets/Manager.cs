using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public CiudadanosInformacion ciuInformacion; //Declara la estructura que contiene la información del ciudadano
    public ZombiesInformacion zomInformacion; //Declara la estructura que contiene la información del zombie
    void Start()
    {
        int puntoApa = -1; //Inicia variable en -1 para iniciar el default del switch y crear el heroe
        zomInformacion.color = new Color[] { Color.cyan, Color.green, Color.magenta }; //Asigna los valores de color al array del color del zombie
        for (int i = 0; i < Random.Range(10, 20); i ++) //Bucle que crea las primitivas de cubo para ciudadano, zobie y heroe. Contiene un switch que asigna la identidad a cada primitiva
        {
            GameObject humanoide = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            humanoide.transform.position = pos;
            switch (puntoApa)
            {
                case 1:
                    humanoide.name = "Ciudadano";
                    humanoide.AddComponent<Ciudadanos>();
                    break;

                case 2:
                    humanoide.name = "Zombie";
                    humanoide.AddComponent<Zombies>();
                    humanoide.GetComponent<Renderer>().material.color = zomInformacion.color[Random.Range(0, 3)];
                    break;

                default:
                    humanoide.name = "Hero";
                    humanoide.gameObject.tag = "Player";
                    humanoide.AddComponent<Hero>();
                    humanoide.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow); 
                    break;
            }
            puntoApa = Random.Range(1, 3); //Valor aleatorio para añadir la identidad al cubo
        }
    }
}
