using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingblock : MonoBehaviour
{public Rigidbody rb;
public Transform Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {rb.AddForce(-6 * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        if(Cube.position.x < -3)
        rb.AddForce(10 * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
    }
}
