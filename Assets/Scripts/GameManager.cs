using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //find by name white save it in int

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("White") ==null)
        {
            Debug.Log("Level Complete");
            //Level Complete
        }
    }
    
}
