using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public CiudadanosInformacion ciuInfo; //Declara la estructura que contiene la información del ciudadano
    public ZombiesInformacion zomInfo; //Declara la estructura que contiene la información del zombie
    void Start() //Método Start, añade los scripts de movimiento al heroe, añade la camara principal como hijo y le añade un script de "mira"
    {
        gameObject.AddComponent<FPSmouse>();
        gameObject.AddComponent<FPS>().velocidad = Random.Range(5f, 20f);
        gameObject.AddComponent<Rigidbody>().freezeRotation = enabled;
        Camera.main.gameObject.transform.localPosition = gameObject.transform.position;
        Camera.main.transform.SetParent(gameObject.transform);
        Camera.main.gameObject.AddComponent<FPSmouse>();
    }

    public void OnCollisionEnter(Collision collision) //Método OnCollisionEnter, compara si con el cubo que colisione es ciudadano o zombie, muestre el mesaje correspondiente
    {
        if (collision.gameObject.GetComponent<Ciudadanos>())
        {
            ciuInfo = collision.gameObject.GetComponent<Ciudadanos>().ciudadanosInfo(); //Asigna la información del ciudadano para usar en el mensaje
            Debug.Log("Hola soy" + " " + ciuInfo.nombre + " " + "y tengo" + ciuInfo.edad); //Mensaje que da el ciudadano al entrar en contacto
        }

        if (collision.gameObject.GetComponent<Zombies>())
        {
            zomInfo = collision.gameObject.GetComponent<Zombies>().ZombiesInfo(); //Asigna la información del zombie para usar en el mensaje
            Debug.Log("Waaaarrr quiero comer" + " " + zomInfo.gusto); //Mensaje que da el zombie al entrar en contacto
        }
    }
}