using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip reee;
    public AudioSource sourceEngine;
    // Start is called before the first frame update
    void Start()
    {
        sourceEngine.clip = reee;
        sourceEngine.Play();
    }

    
}
