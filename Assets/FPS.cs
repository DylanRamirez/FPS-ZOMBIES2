using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public float velocidad; //Varibale creada para la velocidad del personaje

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))// Condicion donde entra si se oprime la tecla W
        {
            transform.position += transform.forward * (velocidad * Time.deltaTime);// Establece la direccion y la velocidad a la que se va a mover el jugador
        }
        if (Input.GetKey(KeyCode.S))// Condicion donde entra si se oprime la tecla S
        {
            transform.position -= transform.forward * (velocidad * Time.deltaTime);// Establece la direccion y la velocidad a la que se va a mover el jugador
        }
        if (Input.GetKey(KeyCode.A))// Condicion donde entra si se oprime la tecla A
        {
            transform.position -= transform.right * (velocidad * Time.deltaTime);// Establece la direccion y la velocidad a la que se va a mover el jugador
        }
        if (Input.GetKey(KeyCode.D))// Condicion donde entra si se oprime la tecla D
        {
            transform.position += transform.right * (velocidad * Time.deltaTime);// Establece la direccion y la velocidad a la que se va a mover el jugador
        }
    }
}
