using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaMeta : MonoBehaviour
{
    //VARIABLES:

    int Total_Checks; //VARIABLE PARA DETERMINAR LA CANTIDAD DE CHECKPOINTS QUE TIENE LA PISTA.
    public GameObject Temporal;
    void Start()
    {
        Total_Checks = 3; //seteamos que hay 3 checkpoints;
    }

    private void OnTriggerEnter(Collider other)
    {
        //PASO 1: VERIFICAR QUE LO QUE COLISIONA ES UN VEHICULO, YA QUE POR ERROR PUEDE COLISIONAR
        //OTRA COSA POR EJEMPLO UNA BALA LANZADA, PARTE DEL ESCENARIO SI ES MOVIL, ETC !
        if (other.GetComponent<VerificadorVuelta>() !=null) 
        {
            //LA CONDICION PUEDE SER CAMBIADA A FUTURO DEPENDE COMO EVOLUCIONE EL "COCHE".
            //MOMENTANEAMENTE SABEMOS QUE ES UN AUTO LO QUE COLISIONA ENTONCES:

            //PASO 2: SE CUMPLIERON LOS CHECKPOITNS??

            bool Verifico_Vuelta_Completa=false;
        for (int i =0; i < Total_Checks; i++)
            {
                //si algun checkpoint esta en false el resultado final va a ser false.
                Verifico_Vuelta_Completa = other.gameObject.GetComponent<VerificadorVuelta>().CheckPoints[i];
            }

        if (Verifico_Vuelta_Completa == true)
            {
                other.GetComponent<VerificadorVuelta>().VueltaN = other.GetComponent<VerificadorVuelta>().VueltaN + 1;
                if (other.GetComponent<VerificadorVuelta>().VueltaN > 3)
                {
                    Temporal.SetActive(true);
                }
                else
                {
                    other.GetComponent<VerificadorVuelta>().MostrarVuelta = true;
                }
            }
            else
            {
                if (other.GetComponent<VerificadorVuelta>().VueltaN == 0) other.GetComponent<VerificadorVuelta>().VueltaN = 1;
            }

        }
        else
        {
            //COLISIONA OTRA COSA, ESTA LINEA SI NO ES USADA LA PODEMOS ELIMINAR.
        }


    }

}
