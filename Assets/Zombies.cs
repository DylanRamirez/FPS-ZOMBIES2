using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Zombies : MonoBehaviour
{
    ZombiesInformacion zomInfo; //Declara la estructura que contiene la información del zombie
    int movi; //Variable tipo int para usar en switch

    void Start() //Método Start, inicia la corrutina de comportamiento, asigna aleatoriamente el gusto del zombie, congela la rotación del Rigidbody del zombie cuando colisionen
    {
        StartCoroutine(Behaviour());
        zomInfo.gusto = (Gusto)Random.Range(0, 5);
        gameObject.GetComponent<Rigidbody>().freezeRotation = enabled;
    }

    void Movimiento() //Método para verificar el comportamiento del zombie, si se mueve o se queda quieto
    {
        if (zomInfo.behaviour == global::ZombiesBehaviour.moving)
        {
            movi = Random.Range(1, 5);
            StartCoroutine(Behaviour());
        }
        else
        {
            movi = 5;
            StartCoroutine(Behaviour());
        }
    }

    void Update() //Método update, contiene un switch que se decide aleatoriamente para mover el zombie en una dirección aleatoria si el comportamiento es de moverse
    {
        switch (movi)
        {
            case 1:
                transform.position += transform.forward * 2f * Time.deltaTime;
                break;
            case 2:
                transform.position += transform.forward * 2f * Time.deltaTime;
                break;
            case 3:
                transform.position += transform.right * 2f * Time.deltaTime;
                break;
            case 4:
                transform.position += transform.right * 2f * Time.deltaTime;
                break;
            case 5:
                transform.position += new Vector3(0, 0, 0);
                break;
        }
    }

    IEnumerator Behaviour() //Corrutina que elige aleatoriamente el comportamiento del zombie que proviene de un enumerador. También llama el metodo que verifica el comportamiento asignado
    {
        yield return new WaitForSeconds(5);
        zomInfo.behaviour = (ZombiesBehaviour)Random.Range(0, 2);
        Movimiento();
        yield return new WaitForSeconds(5);
    }

    public ZombiesInformacion ZombiesInfo() //Función que devuelve la estructura que contiene la información del zombie
    {
        return zomInfo;
    }
}

public struct ZombiesInformacion //Estructura que contiene la información del zombie
{
    public Color[] color;
    public Gusto gusto;
    public ZombiesBehaviour behaviour;
}

public enum ZombiesBehaviour //Enumerador que contiene los comportamientos del zombie
{
    idle,
    moving
}

public enum Gusto //Enumerador que contiene los gustos del zombie
{
    piernas,
    brazos,
    tronco,
    cerebro,
    tripas
}