using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject car;
    public GameObject camera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(10, 10, 10);
            GameObject temp= Instantiate(car, pos, Quaternion.identity);
            camera.GetComponent<SmoothFollow>().target = temp.transform;
        } 
    }
}
