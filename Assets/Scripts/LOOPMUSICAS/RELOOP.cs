using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RELOOP : MonoBehaviour
{
    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.time = 3.658f;
            audioSource.Play();
        }
    }
}
