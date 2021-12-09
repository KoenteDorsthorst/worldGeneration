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
                


                
                int random = Random.Range(1, 10);
                int height = 1;
                if(random > 8)
                {
                    height = 3;
                }
                else if(random > 7){
                    height = 2;
                }


                for (int h = 0; h < height; h++)
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(i, h, n);
                    cube.AddComponent<BoxCollider>();
                    cube.name = "Cube " + i + " " + n + " " + h;
                }
                
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
