using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APAGAR1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool ApagarAqui;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ApagarAqui == true) this.gameObject.SetActive(false);
    }
}
