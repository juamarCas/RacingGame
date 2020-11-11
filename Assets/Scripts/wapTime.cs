using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wapTime : MonoBehaviour
{
    private float Tiempo = 2f;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo <= 0)
        {
            Tiempo = 2f;
            Destroy(this.gameObject);
        }
        else
        {
            Tiempo -= Time.deltaTime;
        }
    }

}
