using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadanos : MonoBehaviour
{
    public CiudadanosInformacion ciuInformacion;  //Declara la estructura que contiene la información del ciudadano
    void Start()  //Método Start, asigna la edad y el nombre a cada ciudadano de manera aleatoria. El nombre esta almacenado en un enumerador.
    {
        ciuInformacion.edad = Random.Range(15, 100);
        ciuInformacion.nombre = (CiudadanosNomb)Random.Range(0, 19);
    }

    public CiudadanosInformacion ciudadanosInfo() //Función que devuelve la estructura que contiene loa información del ciudadano
    {
        return ciuInformacion;
    }
}

public enum CiudadanosNomb //Enumerador que contiene los nombres que se asignaran de manera aleatoria
{
    Ichigo,
    Naruto,
    Goku,
    Luffy,
    kira,
    Yohany,
    Felipe,
    Yeral,
    Tatiana, // Uno de los nombres del enum
    Estefa,
    Aleja,
    Sara,
    Laura,
    Luciana,
    Santiago,
    Juanjose,
    ElBryan,
    Sebastian,
    Jorge,
    Anderson
}

public struct CiudadanosInformacion  //Estructura que contiene la información del ciudadano
{
    public int edad;
    public CiudadanosNomb nombre;
}
