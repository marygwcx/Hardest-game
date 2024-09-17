using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //else if(Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3((-1 * speed) * Time.deltaTime, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, (-1 * speed) * Time.deltaTime);
        //}
        //var-select the type of variable
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //normalized - move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;

    }
}
