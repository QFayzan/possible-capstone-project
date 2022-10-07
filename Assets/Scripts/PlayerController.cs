using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Characters
{
    
    // Start is called before the first frame update
    void Start()
    {
       moveSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //base. keyword is used for inheritence
        BasicMovement();
    }
    
}
