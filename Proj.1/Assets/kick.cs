using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    Rigidbody rb;
    float kickStrength = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }


    void KickBall(Transform character)
    {
        rb.AddForce(kickStrength * character.forward, ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("Boing"); }
        else
        {
            print("Ouch");
            KickBall(collision.transform);
        }
    }
}