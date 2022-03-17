using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float begin;
    public float dist = 5;
    public float speed = 5;
    public int dir;
    void Start()
    {
        begin = transform.position.x;
        dir = 1;
    }
    void Update()
    {
        // you should'nt need a non-kinetic rigidbody attached for this simple movement!!!
        if (transform.position.x > begin + dist)
        {
            dir = -1;
        }else
        {
            if (transform.position.x < begin - dist)
            {
                dir = 1;
            }
        }
        

        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * dir, transform.position.y, transform.position.z);
    }
}
