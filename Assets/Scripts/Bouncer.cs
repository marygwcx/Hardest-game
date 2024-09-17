using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{

    public float speed = 5.0f;
    public float height = 3.0f;
    
    void Update()
    {
        var y = Mathf.Sin(Time.time * speed) * height;

        if (y < 0) y = -y;

        var x = transform.position.x;
        var z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
