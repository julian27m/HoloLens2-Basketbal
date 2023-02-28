using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swish : MonoBehaviour
{
    //Swish sound
    public AudioSource swish;

    // Start is called before the first frame update
    void Start()
    {
        swish = GetComponent<AudioSource>();
    }

    //The net is going to make a swish sound when the ball passes through it
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            swish.Play();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
