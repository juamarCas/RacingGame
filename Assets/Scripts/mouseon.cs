using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseon : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public GameObject cuadrado, Okey, Bipi;
    public GameObject Contenedor2;
     

    public void OnPointerEnter(PointerEventData eventData)
    {
        cuadrado.transform.position = this.transform.position;
        Bipi.GetComponent<AudioSource>().Play();
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (this.gameObject.name == "JUGAR")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Okey.GetComponent<AudioSource>().Play();
                Contenedor2.SetActive(true);
                APAGAR1.ApagarAqui = true;
            }
            
            //if (Input.GetMouseButtonDown(1)) Debug.Log("Pressed right click.");
            //if (Input.GetMouseButtonDown(2)) Debug.Log("Pressed middle click.");
        }
        if (this.gameObject.name == "OK_PERSONAJE")
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("TestRoom");
            }

            //if (Input.GetMouseButtonDown(1)) Debug.Log("Pressed right click.");
            //if (Input.GetMouseButtonDown(2)) Debug.Log("Pressed middle click.");
        }
    }
}
