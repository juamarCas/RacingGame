using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificadorVuelta : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[] CheckPoints;

    private void Start()
    {
        //AQUI SE DEBE PONER LA CANTIDAD QUE TENGA CADA PISTA.
        //TEMPORALMENTE PONDREMOS 3 CHECPOINTS
        CheckPoints = new bool[3];
    }



}
