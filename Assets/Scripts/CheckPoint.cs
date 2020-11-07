using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    
    [Header ("Numero de Checkpoint")]
    public int Numero_Checkpoint; //DETERMINA EL NUMERO DE CHECKPOINT QUE ES.

    private void OnTriggerEnter(Collider other)
    {
        ///PASO 1: VERIFICAR QUE LO QUE COLISIONA ES UN VEHICULO, YA QUE POR ERROR PUEDE COLISIONAR
        //OTRA COSA POR EJEMPLO UNA BALA LANZADA, PARTE DEL ESCENARIO SI ES MOVIL, ETC !

        if (other.gameObject.GetComponent<VerificadorVuelta>() != null)
        {
            //Debug.Log("ok");
            //SI ES UN COCHE LO QUE ME COLISIONO, ENTONCES:

            //PASO 2: VERIFICO QUE EL ANTERIOR CHECKPOINT ESTE HECHO, SINO NO PUEDO DARLE MI OK.
            if (Numero_Checkpoint == 0) //pero si soy el cero si o si le asigno.
            {
                other.gameObject.GetComponent<VerificadorVuelta>().CheckPoints[Numero_Checkpoint] = true;
                other.gameObject.GetComponent<VerificadorVuelta>().Mostrar_Parcial = true;
                Borrar.Playme = true;
            }
            else
            {
                if (other.gameObject.GetComponent<VerificadorVuelta>().CheckPoints[Numero_Checkpoint - 1] == true)
                {
                    other.gameObject.GetComponent<VerificadorVuelta>().CheckPoints[Numero_Checkpoint] = true;
                    other.gameObject.GetComponent<VerificadorVuelta>().Mostrar_Parcial = true;
                    Borrar.Playme = true;
                }
            }
        }

    }

}
