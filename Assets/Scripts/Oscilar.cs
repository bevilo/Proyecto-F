using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour
{
    public Vector3 Frecuencia;
    public Vector3 Traslacion;
    public Vector3 Rotacion;
    
    private Vector3 InitialTraslacion;
    private Quaternion InitialRotacion;

    void Start()
    {
        InitialRotacion = transform.localRotation;
        InitialTraslacion = transform.localPosition;
    }
    void Update()
    {
        transform.localRotation = InitialRotacion*Quaternion.Euler(new Vector3(Rotacion.x * Mathf.Sin(Frecuencia.x* Time.time),Rotacion.y * Mathf.Sin(Frecuencia.y* Time.time),Rotacion.z * Mathf.Sin(Frecuencia.z* Time.time)));
        transform.localPosition = InitialTraslacion+new Vector3(Traslacion.x * Mathf.Sin(Frecuencia.x* Time.time),Traslacion.y * Mathf.Sin(Frecuencia.y* Time.time),Traslacion.z * Mathf.Sin(Frecuencia.z* Time.time));
    }
}
