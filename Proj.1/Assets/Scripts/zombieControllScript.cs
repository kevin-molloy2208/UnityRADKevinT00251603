using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieControllScript : MonoBehaviour
{
    Ball_Movement player;
   
    Animator zombieAnimator;


    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectofType<Ball_Movement>();
        zombieAnimator = GetComponent<Animator>();
        Enum ZombieState; { Idle, Follow, Attack}
        ZombieState currentlyIs = ZombieState Idle;

    }

    // Update is called once per frame
    void Update()
    {switch(currentlyIs)
            
                case ZombieState.Idle;
                    if (Vector3.Distance(player.transform.position, transform.position))<aggroRadius


       if (Input.GetKey(KeyCode.Space))
            zombieAnimator.SetBool("isWalking", true);
        else
            zombieAnimator.SetBool("isWalking", false);
     if (Input.GetKey(KeyCode.D))
            zombieAnimator.SetBool("isDead", true);
        else
            zombieAnimator.SetBool("isDead", false);

    }
}
