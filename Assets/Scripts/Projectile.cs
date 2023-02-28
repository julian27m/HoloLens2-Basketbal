using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour


{
    // Start is called before the first frame update
    //public variable ThrowSpeed
    public float ThrowSpeed;
    //public variable ThrowForce
    public float ThrowForce;
    public GameObject ProjectilePrefab;

    public AudioSource bounce;
    void Start()
    {
        bounce = GetComponent<AudioSource>();
    }
    public void ThrowObject(GameObject obj)
    {
        Vector3 throwDirection = Camera.main.transform.forward;
        throwDirection.y = 0.5f;
        throwDirection.Normalize();
        obj.GetComponent<Rigidbody>().AddForce(throwDirection * ThrowForce, ForceMode.Impulse);
        obj.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(-1f, 1f), 0), ForceMode.Impulse);
    }

    // The ball is going to make a sound when it hits the floor
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            bounce.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
