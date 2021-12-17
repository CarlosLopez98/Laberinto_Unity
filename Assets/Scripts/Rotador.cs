using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidad * Time.deltaTime, 0, 0);
    }
}
