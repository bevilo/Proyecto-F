using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float velocidad;
    public Vector3 eje;
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(velocidad * Time.deltaTime,eje);
    }
}
