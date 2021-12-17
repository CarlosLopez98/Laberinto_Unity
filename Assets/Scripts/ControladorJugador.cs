using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJugador : MonoBehaviour
{
    public float velocidad = 10f;
    Rigidbody miRigidBody;
    Vector3 posicionInicial;
    int monedas = 0;
    int vidas = 3;
    public Text Puntaje;
    public Text Vidas;

    // Start is called before the first frame update
    void Start()
    {
        miRigidBody = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        miRigidBody.AddForce(new Vector3(horizontal, 0, vertical) * velocidad);

        Puntaje.text = "Puntaje: " + monedas;
        Vidas.text = "Vidas: " + vidas;
    }

    void OnTriggerEnter(Collider colision)
    {
        if (colision.CompareTag("Salida"))
        {
            Debug.Log("Muy bien, has finalizado el recorrido.");
        }
        else if (colision.CompareTag("Enemigo"))
        {
            Debug.Log("Has muerto");
            miRigidBody.MovePosition(posicionInicial);
            miRigidBody.velocity = Vector3.zero;
            miRigidBody.angularVelocity = Vector3.zero;

            vidas -= 1;
            Vidas.text = "Vidas: " + vidas;
        }
        else if (colision.CompareTag("Moneda"))
        {
            Debug.Log("Recogiste una moneda");
            colision.gameObject.SetActive(false);

            monedas += 1;
            Puntaje.text = "Puntaje: " + monedas;
        }
    }
}
