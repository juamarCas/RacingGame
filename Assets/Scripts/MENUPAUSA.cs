using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUPAUSA : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool PAUSADO = false;
    public GameObject Camara, UI_minicamara;
    public GameObject TextooMIP, Contenedor;
    public GameObject flecha;
    private bool Prender_Apagar = true;
    private bool Rectificativa = true; 

    float Esp_Pausa = 0;
    int Esp_Altura = 0;

    // Update is called once per frame
    void Update()
    {
       

        if (PAUSADO == true)
        {
            if (Input.GetAxis("Vertical") == 0) Esp_Pausa = 0.0f;

            if (Input.GetAxis("Vertical") < 0)
            {
                if (Esp_Pausa > 0)
                {
                    Esp_Pausa -= Time.deltaTime;
                }
                else
                {
                    Esp_Altura = Esp_Altura + 1;
                    Esp_Pausa = 0.25f;
                }
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                if (Esp_Pausa > 0)
                {
                    Esp_Pausa -= Time.deltaTime;
                }
                else
                {
                    Esp_Altura = Esp_Altura - 1;
                    Esp_Pausa = 0.25f;
                }
            }

            if (Esp_Altura > 2) Esp_Altura = 0;
            if (Esp_Altura < 0) Esp_Altura = 2;

            switch (Esp_Altura)
            {
                case 0:
                    flecha.transform.localPosition = new Vector2(flecha.transform.localPosition.x, 93);
                    break;
                case 1:
                    flecha.transform.localPosition = new Vector2(flecha.transform.localPosition.x, -21);
                    break;
                case 2:
                    flecha.transform.localPosition = new Vector2(flecha.transform.localPosition.x, -126);
                    break;
            }


            if (Input.GetButtonDown("Aceptar") && Rectificativa==true)
            {
                switch (Esp_Altura)
                {
                    case 0:
                        PAUSADO = false;
                        Contenedor.SetActive(false);
                        Rectificativa = false;
                        break;
                    case 1:
                        if (Prender_Apagar == true)
                        {
                            TextooMIP.GetComponent<TextMeshProUGUI>().text = "Prender Mipmap";
                            Prender_Apagar = false;
                        }
                        else
                        {
                            TextooMIP.GetComponent<TextMeshProUGUI>().text = "Apagar Mipmap";
                            Prender_Apagar = true;
                        }
                        Camara.SetActive(Prender_Apagar);
                        UI_minicamara.SetActive(Prender_Apagar);
                        break;
                    case 2:
                        APAGAR1.ApagarAqui = false;
                        SceneManager.LoadScene("MENU_PRINCIPAL");
                        break;
                }
            }
        }

        if (Input.GetButtonDown("Aceptar") && PAUSADO == false && Rectificativa==true)
        {
            Contenedor.SetActive(true);
            PAUSADO = true;
            Rectificativa = false;
        }

        if (Input.GetButtonUp("Aceptar")) Rectificativa = true;



    }
}
