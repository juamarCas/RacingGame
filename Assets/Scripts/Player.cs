using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody sphere;

    [Header("Componentes")]
    public float gravity = 10.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sphere.transform.position - new Vector3(0, 0.4f, 0); 
    }


    private void FixedUpdate()
    {
        //gravity
        sphere.AddForce(Vector3.down * gravity, ForceMode.Acceleration); 
    }
}
