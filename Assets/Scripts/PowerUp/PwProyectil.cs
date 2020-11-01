using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PwProyectil : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 8f);
        gameObject.transform.Translate(new Vector3(0f, 0f, 0.5f));
    }
}
