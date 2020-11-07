
using UnityEngine;
using System.Timers;
using TMPro;


public class TIEMPO : MonoBehaviour
{
    // Start is called before the first frame update
    public static string CopiaTiempo;
    public float Tiempo=0;
    Timer T = new Timer();

    string Minutos = "00", Segundos ="00", Milisegundos = "00";
  
    void Start()
    {
        T.Elapsed += new ElapsedEventHandler(PrenderTimer);
        T.Interval = 100;
        T.Start();
    }

    void PrenderTimer(object Origen, ElapsedEventArgs e)
    {
        Tiempo++;
    }

    private void Update()
    {
        if ((int) (Tiempo/600) %60 < 10)
        {
            Minutos = "0" + (int)(Tiempo / 600) % 60;
        }
        else
        {
            Minutos = "" + (int)(Tiempo / 600) % 60;
        }

        if (System.Math.Round((Tiempo % 600) / 10f,0) < 10)
        {
            Segundos = "0" + System.Math.Round((Tiempo % 600) / 10f,0);
        }
        else
        {
            Segundos = "" + System.Math.Round((Tiempo % 600) / 10f, 0);
        }

        //FALTA LOS MILISEGUNDOSSSSSSSSSSSSSS COMO SE CALCULAN??? CONSULTAR!
        
        
        this.GetComponent<TextMeshProUGUI>().text = "" + Minutos + ":" + Segundos + ":" + Milisegundos;
        CopiaTiempo = this.GetComponent<TextMeshProUGUI>().text;
    }





    /*
    // Update is called once per frame
    void Update()
    {
        Segundos += Time.deltaTime;

        if (Segundos >= 59.99f)
        {
            Segundos = 0f;
            Minutos = Minutos + 1;
        }

        if (Segundos < 10)
        {
            MostrarSegundos = "0" + System.Math.Round(Segundos, 0);
        }
        else
        {
            MostrarSegundos = "" + System.Math.Round(Segundos, 0);
        }
        if (Minutos < 10)
        {
            MostrarMinutos = "0" + Minutos;
        }
        else
        {
            MostrarMinutos = "" + Minutos;
        }
        this.GetComponent<TextMeshProUGUI>().text = "" + MostrarMinutos + ":" + MostrarSegundos; //+ ":" + System.Math.Round(Milisegundos,2);
    }
    */

}
