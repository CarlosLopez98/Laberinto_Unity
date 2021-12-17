using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEnemigo : MonoBehaviour
{
    public float initPos;
    public float finalPos;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        initPos = -6.65f;
        finalPos = 0.86f;
        velocidad = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position[2] = 0;
    }
}
