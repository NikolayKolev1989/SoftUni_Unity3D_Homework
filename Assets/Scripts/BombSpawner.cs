using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    
    private Vector3 bombSpawnPosition;
    private void Awake()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

       bombSpawnPosition = new Vector3(x, y-1, z);
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(bomb, transform.position, Quaternion.identity);
            bomb.SetActive(true);
        }

        

        
       
    } 
}
