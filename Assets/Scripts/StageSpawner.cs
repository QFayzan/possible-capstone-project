using UnityEngine;
 using System.Collections;
 
 public class StageSpawner : MonoBehaviour {
 public GameObject floor;
 private int lastStageLength =4;
 public static int stageLength =4;
 private int ColumnLength =3;
 private int RowHeight =3;
 public static int totalTiles = 0;
 public GameObject[,] stageUnit;
 // Use this for initialization
 void Start()
 {
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
        TotalTiles();
 }
    void Update()
    {
        if (stageLength > lastStageLength)
        {
            DestroyStage();
            SpawnStage();
            lastStageLength = stageLength;
        }
    }
    int TotalTiles()
    {
        totalTiles = stageLength * ColumnLength;
        return totalTiles;
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
        TotalTiles();
    }
    public void DestroyStage()
    {
       // Destroy(GameObject.FindGameObjectsWithTag)
        
    }
 }