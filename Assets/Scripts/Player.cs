using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
//comentario arbitrario
    public Rigidbody sphere;

    [Header("Componentes")]
    public float gravity = 10.0f;
    public float speed, currentSpeed;
    public float rotate, currentRotate;
    public Transform kartNormal;
    public GameObject kartModel; 
    public LayerMask layer; 

    [Header("Parameters")]
    public float acceleration = 30f;
    public float steering = 80f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MENUPAUSA.PAUSADO == false)
        {
           if (Input.GetKey(KeyCode.W))
            {
                speed = acceleration;
            }

            transform.position = sphere.transform.position - new Vector3(0, 0.4f, 0);

            if (Input.GetAxis("Horizontal") != 0)
            {
                int dir = Input.GetAxis("Horizontal") > 0 ? 1 : -1;
                float amount = Mathf.Abs((Input.GetAxis("Horizontal")));
                Steer(dir, amount);
            }

            currentSpeed = Mathf.SmoothStep(currentSpeed, speed, Time.deltaTime * 12f); speed = 0f;
            currentRotate = Mathf.Lerp(currentRotate, rotate, Time.deltaTime * 4f); rotate = 0f;
        }
        else
        {
            sphere.transform.position = transform.position;
        }

    }


    private void FixedUpdate()
    {
        if (MENUPAUSA.PAUSADO == false)
        {
            sphere.AddForce(transform.forward * currentSpeed, ForceMode.Acceleration);
            //gravity
            sphere.AddForce(Vector3.down * gravity, ForceMode.Acceleration);

            //steering
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, transform.eulerAngles.y + currentRotate, 0), Time.deltaTime * 5f);

            RaycastHit hitOn;
            RaycastHit hitNear;

            Physics.Raycast(transform.position + (transform.up * .1f), Vector3.down, out hitOn, 1.1f, layer);
            Physics.Raycast(transform.position + (transform.up * .1f), Vector3.down, out hitNear, 2.0f, layer);

            kartNormal.up = Vector3.Lerp(kartNormal.up, hitNear.normal, Time.deltaTime * 8.0f);
            kartNormal.Rotate(0, transform.eulerAngles.y, 0);
        }
    }

    void Steer(int dir, float amaount)
    {
        rotate = (steering * dir) * amaount; 
    }
}
