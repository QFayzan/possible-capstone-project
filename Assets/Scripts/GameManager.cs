using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : Characters
{
    public TextMeshProUGUI ScoreToGet;
    int endgame = 0;
    float endgame2 = 0;
    public static int tilesDestroyed = 0;
    public static int  tilesToDestroy = 0;
    public bool isFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        ShowTilesToDestroy();
        NextStage();
        //RestartGame(); //method to restart 

    }
    //gameplay loop is complete
    void NextStage()     
    {
       endgame = StageSpawner.totalTiles;
       endgame2 = endgame * (0.60f);
        Mathf.RoundToInt(endgame2);
        if (tilesDestroyed > (int)endgame2)
        {
            Debug.Log(tilesDestroyed);
            StageSpawner.stageLength++;
            BounceUp(GameObject.FindGameObjectWithTag("Player"));
            tilesDestroyed = 0;
        }
    }
    //ShowReducing nneds work
    void ShowTilesToDestroy()
    {
        tilesToDestroy = endgame - (int)endgame2; //needs work right here
        ScoreToGet.text = "Tiles to Destroy :  " + Mathf.RoundToInt(tilesToDestroy).ToString();
    }

  
}
