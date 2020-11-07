using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ManagerPowerUPLevel : MonoBehaviour
{
    public GameObject Pw1;
    public float Pw1X;
    public float Pw1Y;
    public float Pw1Z;
    public GameObject Pw2;
    public float Pw2X;
    public float Pw2Y;
    public float Pw2Z;
    public GameObject Pw3;
    public float Pw3X;
    public float Pw3Y;
    public float Pw3Z;
    public GameObject Pw4;
    public float Pw4X;
    public float Pw4Y;
    public float Pw4Z;
    public GameObject Pw5;
    public float Pw5X;
    public float Pw5Y;
    public float Pw5Z;
    public GameObject Pw6;
    public float Pw6X;
    public float Pw6Y;
    public float Pw6Z;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 8)
        {
            Vector3 positionPw1 = new Vector3(Pw1X, Pw1Y, Pw1Z);
            Vector3 positionPw2 = new Vector3(Pw2X, Pw2Y, Pw2Z);
            Vector3 positionPw3 = new Vector3(Pw3X, Pw3Y, Pw3Z);
            Vector3 positionPw4 = new Vector3(Pw4X, Pw4Y, Pw4Z);
            Vector3 positionPw5 = new Vector3(Pw5X, Pw5Y, Pw5Z);
            Vector3 positionPw6 = new Vector3(Pw6X, Pw6Y, Pw6Z);

            Quaternion rotation = new Quaternion();

            Instantiate(Pw1, positionPw1, rotation);
            Instantiate(Pw2, positionPw2, rotation);
            Instantiate(Pw3, positionPw3, rotation);
            Instantiate(Pw4, positionPw4, rotation);
            Instantiate(Pw5, positionPw5, rotation);
            Instantiate(Pw6, positionPw6, rotation);


            timer = 0;
        }
    }
}
