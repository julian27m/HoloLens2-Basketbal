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
    void Start()
    {
        
    }
    public void ThrowObject(GameObject obj)
    {
        Vector3 throwDirection = Camera.main.transform.forward;
        throwDirection.y = 0.5f;
        throwDirection.Normalize();
        obj.GetComponent<Rigidbody>().AddForce(throwDirection * ThrowForce, ForceMode.Impulse);
        obj.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(-1f, 1f), 0), ForceMode.Impulse);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
