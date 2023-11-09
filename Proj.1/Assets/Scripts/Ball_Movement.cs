using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public Transform ballCloneTemplate;
    float walkspeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        transform.position +=walkspeed* transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        transform.position -=walkspeed* transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 180 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position +=walkspeed* transform.right* Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -180 * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -=walkspeed* transform.forward * Time.deltaTime;

     
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Transform newBall = Instantiate(ballCloneTemplate, transform.position + transform.forward,
                Quaternion.identity);
            kick myNewBallScript =
                newBall.GetComponent<kick>();

            myNewBallScript.KickBall(transform);
        }
    }
}
