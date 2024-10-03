using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballScript : MonoBehaviour
{
    Rigidbody rb;
    

    internal void Kick()
    {
        print("I've been kicked");
        rb.AddExplosionForce(500, transform.position + new Vector3(0, -1, -1), -2);

    }

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
