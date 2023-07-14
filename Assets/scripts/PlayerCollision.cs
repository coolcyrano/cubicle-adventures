using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ public PlayerMovement movement;
   public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
          movement.enabled = false;
          FindObjectOfType<GameManager>().EndGame();
        }
         if (collisionInfo.collider.tag == "speedboost")
         {
           rb.AddForce(0, 4000 * Time.deltaTime, 0, ForceMode.VelocityChange);
         }
    }
}
