using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PlaneColider : MonoBehaviour
{
    public static GameObject Portal = null;
    private Vector3 Re_Aparece;
    private void OnTriggerEnter(Collider other)
    {
        if (Portal != null)
        {
            if (other.GetComponent<VerificadorVuelta>() != null)
            {
                float Medio = Portal.transform.position.x + (other.GetComponent<Collider>().bounds.size.x / 2);
                other.transform.position = new Vector3(Medio, Portal.transform.position.y + 10, Portal.transform.position.z);
                Re_Aparece = other.transform.position;
                Efecto_Warp();
            }
        }
        else
        {
            Portal = GameObject.FindGameObjectWithTag("Finish");
            float Medio = Portal.transform.position.x + (other.GetComponent<Collider>().bounds.size.x / 2);
            other.transform.position = new Vector3(Medio, Portal.transform.position.y + 10, Portal.transform.position.z);
            Re_Aparece = other.transform.position;
            Efecto_Warp();
        }
    }



    void Efecto_Warp()
    {
        GameObject instance =  Instantiate(Resources.Load("WARP", typeof(GameObject))) as GameObject;
        instance.transform.position = Re_Aparece;
    }
}
