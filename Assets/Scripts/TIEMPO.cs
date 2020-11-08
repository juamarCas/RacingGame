
using UnityEngine;
using TMPro;


public class TIEMPO : MonoBehaviour
{
    float t=0;
    float StartTime;
    int Minutos ;
    float Segundos;
    string MM, SS;
    public static string CopiaTiempo;

    void Start()
    {
        StartTime = Time.time;
    }

    void Update()
    {
       float t = Time.time - StartTime;

        Minutos = ((int)t / 60);
        if (Minutos < 10) MM = "0"; else SS = "";

        Segundos = (t % 60);
        if (Segundos < 10) SS = "0"; else SS = "";
        SS += Segundos.ToString("F2");

        this.GetComponent<TextMeshProUGUI>().text = "" + MM + Minutos + ":" + SS;

        CopiaTiempo = this.GetComponent<TextMeshProUGUI>().text;
    }

}
