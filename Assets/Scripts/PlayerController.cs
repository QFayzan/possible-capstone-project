using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerController : Characters
{
    //maybe if i ever need to reset position
   // Vector3 startingPostion = new Vector3(-1, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 3;
        health = 3;
        jumpTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        jumpTimer += Time.deltaTime;
        //base. keyword is used for inheritence
        BasicMovement();
        CanJump();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            if (health > 0)
            {
                BounceUp(this.gameObject);
                health--;
            }
            else if (health < 1)
            {
                Death();
            }

        }

    }
    
}
