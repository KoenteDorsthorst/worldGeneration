using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    GameObject objToSpawn;


    int xStartPoint = 0;
    int yStartPoint = 0;

    int width = 10;
    int length = 10;

    void Start()
    {


        int[,] heightMap = new int[length, width];

        heightMap = fillInHeightMap(heightMap);

        heightMap[3, 7] = 3;

        
        
        

        for(int i = yStartPoint; i < length; i++)
        {
            Debug.Log(i);
            for(int n = xStartPoint; n < width; n++)
            {
                Debug.Log("------");
                Debug.Log(n);
                int height = heightMap[i, n];


                for (int h = 0; h < height; h++)
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(n, h, i);
                    cube.AddComponent<BoxCollider>();
                    cube.name = "Cube " + i + " " + n + " " + h;
                }
                Debug.Log(i);
                Debug.Log(height);
            }
        }
        
    }

    int[,] fillInHeightMap(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[i, n] = 1;
            }
        }
        return array;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
