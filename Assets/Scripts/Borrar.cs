using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borrar : MonoBehaviour
{
    public static bool  Playme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Playme == true) { this.GetComponent<AudioSource>().Play(); Playme = false; }
    }
}
