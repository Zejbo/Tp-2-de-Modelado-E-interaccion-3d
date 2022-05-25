using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadDeUsuario;
    public Text mitext; 
    // Start is called before the first frame update
    void Start()
    {
       if(edadDeUsuario >= 18 )
        {
            mitext.text  = "Es mayor de edad" ;
            Debug.Log("Es mayor de edad ");
        }
       else
        {
            mitext.text = "No mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
