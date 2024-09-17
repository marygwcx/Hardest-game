using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   
    void Update()
    {
        var y = transform.position.y;
        var x = transform.position.x+1;
        var z = transform.position.z+1;
        transform.position = new Vector3(x, y, z);
    }
}
