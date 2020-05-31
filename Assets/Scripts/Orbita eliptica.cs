using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitaeliptica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float velocidad;
    public Vector3 eje;

    // Update is called once per frame
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(velocidad * Time.deltaTime,eje);
    }
}

/*a=1;
ex=0.017;
ang=linspace(0,2*pi,100);

d=a*(1-ex^2);
r=d/(1+ex*cos(ang));
x=r*cos(ang);
y=r*sin(ang);*/
    