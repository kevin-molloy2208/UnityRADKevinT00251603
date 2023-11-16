using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class kick : MonoBehaviour
{
    Animator zombieAnimator;
    Rigidbody rb;
    float kickStrength = 50;
    public static int killCount = 0;
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
        targetController testIfTarget =
            collision.gameObject.GetComponent<targetController>();
        if (testIfTarget != null)
        {
            Destroy(gameObject);
        }
     
        else
        {
        zombieControllScript testIfZombie =
                collision.gameObject.GetComponent<zombieControllScript>();
            if (testIfZombie != null) 
            {
                testIfZombie.dieNow();
                Destroy(gameObject);
                killCount= killCount+1;
            }
            print(+killCount);
            KickBall(collision.transform);

            

        }
    }
}