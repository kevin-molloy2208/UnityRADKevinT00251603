using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    RigidBody rb;
    float kickStrength = 10
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<RigidBody>()
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        rb.AddForce(kickStrength*Vector3.up, ForceMode.Impulse);

    }
}