using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{

    string contraseñacor;
    string contraseña;
    public Text texto;
    public Text ingreso;
    public GameObject mensaje;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacor = "12345";
        mensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void validarContrasenia()
    {
        contraseña = ingreso.text;
        if (contraseña == contraseñacor)
        {
            mensaje.SetActive(true);
            texto.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            mensaje.SetActive(true);
            texto.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }


    }
}
