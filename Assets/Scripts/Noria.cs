using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noria : MonoBehaviour
{
    public int numCabinas = 0;
    public float radio = 0;
    public float velocidad;
    
    public GameObject cabina;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numCabinas; i++)
        {
            GameObject go = Instantiate(cabina, transform);
            float angulo = 360.0F / numCabinas * i;
            go.transform.localPosition = Quaternion.AngleAxis(angulo, Vector3.forward)*new Vector3(0,radio,0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Rotar r in GetComponentsInChildren<Rotar>())
        {
            r.velocidad=-velocidad;
        }
        transform.localRotation*=Quaternion.AngleAxis(velocidad*Time.deltaTime,Vector3.forward);
    }
}
