using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPwPlayer : MonoBehaviour
{
    // 0- Escuedo
    // 1- Knock
    // 2- Proyectil
    // 3- obstaculo
    // 4- Speed
    // 5- Gancho

    public GameObject Obstaculo;
    public GameObject Proyectil;
    bool shield = false;
    bool PW = false;
    int x;

    void Update()
    {
        if (PW == true)
        {
            if (x == 0)
            {
                shield = true;
                if (x == 0 && Input.GetKey("x"))
                {
                    //Activar animacion de inmunidad
                    //Instansiar GameObjetc ColidderTrigger que proteja al jugador
                    //Si proyectil colisiona, Shield y proyectil se destruyen.
                    //Si Obstaculo colisiona, shield y obstaculo se destruyen.
                    //Si gancho colisiona, shield y gancho se destruyen.
                    //Si Knock colisiona , shield y Knock se destruyen.
                    //Si pasan 7 segundos, Pw queda en false y el poder del personaje se desbance.
                    //Si el personaje preciona X y activa el poder, Pw queda en false y  el poder del personaje se desbance.
                }
            }
            if( x ==  1)
            {
                if (x == 1 && Input.GetKey("x"))
                {
                    //Activar skin de personaje con guante.
                    //Instansiar area colider.
                    //Si Knock colisiona con shield, Knock se destruye.
                    //Si Knock colisiona con Player, Knock se destruye.
                }
            }
            if(x == 2)
            {
                if (x == 2 && Input.GetKey("x"))
                {
                    //Instansia un objeto que se mueve hacia adelante. durante 5 segundos.
                    //El objeto tira un raycast que detecta en 360º si hay un jugador.
                    //Si lo encuentra este colisiona con el y el proyectil se destruye.
                    float Posx = gameObject.transform.position.x;
                    float Posy = gameObject.transform.position.y;
                    float Posz = gameObject.transform.position.z;
                    Quaternion rotation = new Quaternion();
                    Vector3 positionProyectil = new Vector3(Posx, Posy, Posz);
                    Instantiate(Proyectil, positionProyectil, rotation);
                    PW = false;
                }
            }
            if (x == 3)
            {
                if (x == 3 && Input.GetKey("x"))
                {

                    float Posx = gameObject.transform.position.x;
                    float Posy = gameObject.transform.position.y;
                    float Posz = gameObject.transform.position.z;
                    Quaternion rotation = new Quaternion();
                    Vector3 positionObstaculo = new Vector3(Posx, Posy, Posz);
                    Instantiate(Obstaculo, positionObstaculo, rotation);
                    PW = false;

                }
            }
            if (x == 4)
            {
                if (x == 4 && Input.GetKey("x"))
                {
                    //El personaje aumenta su velocidad durante unos segundos.
                    //Modifica su variable speed aumentandola durante unos segundos 
                    //Luego restablenciendola a su valor original.
                }
            }
            if (x == 5)
            {
                if (x == 5 && Input.GetKey("x"))
                {
                    //Tira un proyectil hacia adelante que si colisiona con un objetivo 
                }
            }
        }
    }
    void OnTriggerEnter(Collider Colider)
    {
        if (Colider.gameObject.tag == "PoweUp")
        {
            PW = true;
            x = Random.Range(0, 7);
            Debug.Log(x);
        }
        

    }
}


