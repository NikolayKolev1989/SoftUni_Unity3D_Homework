using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFalling : MonoBehaviour
{
    private float fallingConst = -0.25f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate( 0, fallingConst, 0);
    }
}
