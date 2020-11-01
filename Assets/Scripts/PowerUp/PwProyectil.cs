using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PwProyectil : PowerUp
{
    [SerializeField] private float m_velocity = 5.0f; 

    void Update()
    {
        Destroy(gameObject, 8f);
        gameObject.transform.Translate(new Vector3(0f, 0f, 0.5f));
    }
}
