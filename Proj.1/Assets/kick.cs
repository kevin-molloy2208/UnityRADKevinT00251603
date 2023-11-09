using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class kick : MonoBehaviour
{
    Animator zombieAnimator;
    Rigidbody rb;
    float kickStrength = 50;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void KickBall(Transform character)
    {
        rb.AddForce(kickStrength * character.forward, ForceMode.Impulse);
        rb.AddExplosionForce(kickStrength, character.position, 4);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("Boing"); }
     
        else
        {
        zombieControllScript testIfZombie =
                collision.gameObject.GetComponent<zombieControllScript>();
            if (testIfZombie != null) 
            {
                Destroy(gameObject, 5);
            }
            print("Ouch");
            KickBall(collision.transform);
        }
    }
}