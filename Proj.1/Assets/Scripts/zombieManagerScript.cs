using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManagerScript : MonoBehaviour
{

    public Transform zombieCloneTemplate;

    int numberOfZombies = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfZombies; i++)
        {
            Vector3 position = new Vector3
                (
                Random.Range(17f, -21f),
                0,
                Random.Range(25f, -25f)
                );

            Instantiate(zombieCloneTemplate, position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
