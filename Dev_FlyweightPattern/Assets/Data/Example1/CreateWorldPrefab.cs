using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorldPrefab : MonoBehaviour
{

    public int width=20;
    public int depth=20;
    public GameObject cube;
    
    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for(int z = 0; z < depth; z++)
            {
                Vector3 pos = new Vector3(x, Mathf.PerlinNoise(x*.2f, z *.2f) * 3, z);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
    }

    
}
