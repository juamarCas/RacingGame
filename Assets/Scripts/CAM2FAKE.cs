using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM2FAKE : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 50, Player.transform.position.z);
    }
}
