using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cube;
    public int rows, cols;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int z = 0; z < cols; z++)
            {
                GameObject instance = Instantiate(cube);
                Vector3 pos = new Vector3(x, Mathf.PerlinNoise(x * 0.2f, z * 0.2f));
                instance.transform.position = pos;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
