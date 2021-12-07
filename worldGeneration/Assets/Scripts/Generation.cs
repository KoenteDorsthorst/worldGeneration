using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    GameObject objToSpawn;


    int xStartPoint = -20;
    int yStartPoint = -20;

    int width = 40;
    int height = 40;

    void Start()
    {
        
        

        for(int i = xStartPoint; i < width; i++)
        {
            for(int n = yStartPoint; n < height; n++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);


                int random = Random.Range(0, 2);
                cube.transform.position = new Vector3(i, random, n);
                cube.AddComponent<BoxCollider>();
                cube.name = "Cube " + i + " " + n;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
