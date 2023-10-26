using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieControllScript : MonoBehaviour
{
    Ball_Movement player;

    Animator zombieAnimator;

    
    enum ZombieState {
        Idle,Follow, Attack
    }
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 10;
    private float attack = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Ball_Movement>();
        zombieAnimator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    { switch(currentlyIs)
        {


            case ZombieState.Idle:

            if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("isWalking", true);
                }


                break;

                case ZombieState.Follow:
                    transform.LookAt(player.transform.position);
                    transform.position += 0.3f * transform.forward * Time.deltaTime;
                if (Vector3.Distance(player.transform.position, transform.position) < attack)
                {
                    currentlyIs = ZombieState.Attack;
                    zombieAnimator.SetBool("isAttack", true);
                }

                break;

          

        }
    }
}
