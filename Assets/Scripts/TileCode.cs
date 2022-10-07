using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCode : MonoBehaviour
{
    //more types of tiles can be added here
    bool isExplodeTile = false;
    bool isJumpTile = false;
    bool isNormalTile = false;
    private Rigidbody rb;
    [SerializeField] private int i = 0;

    
    //when a tile object is initialized it will be assigned a color and function on startup

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        i = Random.Range(0,100);
        if (i < 15)
        { //First spporach is to tag here and get player to act as trigger
            //gameobject red
            GetComponent<Renderer>().material.color = Color.red;
            isExplodeTile = true;
            this.gameObject.name = "Red";
            //explode / game over property 
        }
        if (i>15 && i<30)
        {
            //gameobject blue
            GetComponent<Renderer>().material.color = Color.blue;
            isJumpTile = true;
            this.gameObject.name = "Blue";
            //Bounce the player
            //lauches player gently in the air then ends itself
        }
        else if(i>30)
        {
            //white is normal tile
            this.gameObject.name = "White";
            GetComponent<Renderer>().material.color = Color.white;
            isNormalTile = true;

        }
        //more types can be added here
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionExit(Collision other)
    {
       if (other.gameObject.tag=="Player")
       {
        if (isNormalTile)
        { 
        //Score++ when i implement it
        Destroy(gameObject , 0.5f);
        }
        else if(isExplodeTile)
        {
            //Implement bounce and then destroy
            //bounce here
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if(isJumpTile)
        {
            other.transform.position = new Vector3 (other.transform.position.x , 4 , other.transform.position.z);
            Destroy(gameObject);
        }
       }
       
    }
}