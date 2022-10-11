using UnityEngine;
 using System.Collections;
using TMPro;
 
 public class StageSpawner : MonoBehaviour {
 public GameObject floor;
 private int lastStageLength =4;
 public static int stageLength =4;
 private int ColumnLength =4;
 private int RowHeight =4;
 public static int totalTiles = 0;
 public static int roundNumber ;
 public GameObject[,] stageUnit;
 public TextMeshProUGUI roundNumberDisplay;
 // Use this for initialization
 void Start()
 {
    //DOne in start to ensure it remains persistent on restart
    roundNumber = 1;
    stageLength = 4;
    totalTiles = 0;
    totalTiles = stageLength * ColumnLength; //starts the program to calculate the number of tiles generated

    //Basically only edit stage length for rows and columns
    ColumnLength = stageLength;
    RowHeight = stageLength;
    stageUnit = new GameObject[ColumnLength,RowHeight];
     for (int i = 0; i < ColumnLength; i++)
     {
         for (int j = 0; j < RowHeight; j++)
         {
           
             stageUnit[i,j] = (GameObject)Instantiate(floor, new Vector3(i, 0, j), Quaternion.identity);
         }
           
        }
       
    }
    void Update()
    {
        //Used to display current round may add to score 
        roundNumberDisplay.text = "Current Round is  :" + roundNumber.ToString();

        if (stageLength > lastStageLength)
        {
            LoadNextStage();
        }
    }
    public void LoadNextStage()
    {
        DestroyStage();
        SpawnStage();
        lastStageLength = stageLength;
        OnNewRound();
        roundNumber++;
    }
  
   public void SpawnStage()
    {
        //Basically only edit stage length for rows and columns
        ColumnLength = stageLength;
        RowHeight = stageLength;
        stageUnit = new GameObject[ColumnLength, RowHeight];
        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {

                stageUnit[i, j] = (GameObject)Instantiate(floor, new Vector3(i, 0, j), Quaternion.identity);
            }

        }
        totalTiles = stageLength * ColumnLength;
        //Have to set this to 0 since it stays static and messes up the gameplay
        GameManager.tilesDestroyed = 0;
    }
    public void DestroyStage()
    {
       // Destroy(GameObject.FindGameObjectsWithTag)
        
    }
    public void OnNewRound()
    {
        ScoreManager.score += 100;
    }
 }