using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObstacle : MonoBehaviour
{
    public float borderX;
    public float speed;
    public bool MovementRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        borderX = 9f;
        Movement();
    }

    private void Movement()
    {
        if(MovementRight)
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            if(transform.position.x > borderX)
            {
                MovementRight = false;
            }
        }
        else
        {
            transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
            if(transform.position.x < -borderX)
            {
                MovementRight = true;
            }
        }
    }

}
