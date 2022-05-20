using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.currentState == GameManager.GameStates.InGame)
            Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        speed = 5f;
        transform.Translate(Vector3.right * horizontalInput * turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
