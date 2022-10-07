using UnityEngine;
 using System.Collections;
 
 public class StageSpawner : MonoBehaviour {
 public GameObject floor;
 public int stageLength =3;
 private int ColumnLength =3;
 private int RowHeight =3;
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
 }
 void Update()
 {
 }
 }