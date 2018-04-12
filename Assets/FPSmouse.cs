using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmouse : MonoBehaviour
{
    float mouseY;// varaibale creada para la posicion en Y
    float mouseX;// variable creada para la posicion en x
    public bool mouseInver;// variable creada para un booleano
    int lookCase;// variable creada para un Switch

    void Start()
    {
        if (gameObject.CompareTag("MainCamera"))
            lookCase = 1;
        else
            lookCase = 2;
        
    }

    void Update()
    {
        switch (lookCase)// Switch de la variable creada  1.camara  2. personaje
        {
            case 1:
                mouseX += Input.GetAxis("Mouse X");// direccion del mouse en X
                if (mouseInver)// Condicion para la variable booleana creada
                {
                    mouseY += Input.GetAxis("Mouse Y");// direccion del mouse en Y
                    mouseY = Mathf.Clamp(mouseY, -50.0f, 50.0f);// Aqui se esta limitando el rango de vision
                }
                else // si no se cumple la condicion anterior se ejecutara esta 
                {
                    mouseY -= Input.GetAxis("Mouse Y");// Direccion del mouse en Y
                    mouseY = Mathf.Clamp(mouseY, -50.0f, 50.0f);// Aqui se esta limitando el rango de vision
                }
                transform.eulerAngles = new Vector3(mouseY, mouseX);// Los angulos en Y y en X
                break;// Finalizando el caso 1 del Switch
            case 2:
                mouseX += Input.GetAxis("Mouse X");// direccion del mouse en X
                transform.eulerAngles = new Vector3(0, mouseX);// Los angulos de Y y X
                break;// Finalizando el caso 2 del Switch
        }
    }
}