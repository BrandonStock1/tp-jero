using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{

    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text texto;
    public Text ingresoUsuario;
    public GameObject cartelitoMjs;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMjs.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitoMjs.SetActive(true);
            texto.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMjs.SetActive(true);
            texto.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }


    }
}
