using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ValidarContraseña : MonoBehaviour
{
    string contraseniaCorrecta;
   public Text ingresoUsuario;
    string contraseniaUsuario;
    public GameObject cartelitoMsj;
    public Text TextoMsj; 
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ValidarContrania()
     {
        contraseniaUsuario = ingresoUsuario.text;
        if(contraseniaUsuario == contraseniaCorrecta)
        {
            Debug.Log("Bienvenido");
            cartelitoMsj.SetActive(true);
            TextoMsj.text = "Bienvenido";
        }
        else
        {
            TextoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña Incorrecta ");
            cartelitoMsj.SetActive(true);

        }
    }
}
