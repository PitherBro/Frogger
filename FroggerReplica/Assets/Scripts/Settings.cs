using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static float CarSpawnRate = .3f,
                        CarMaxSpeed = 12f,
                        CarMinSpeed = 8f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                
        }
    }

}
