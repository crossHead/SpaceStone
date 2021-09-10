using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float MovementX;
    private float MovementY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        MovementX = movementVector.x;
        MovementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(MovementX, 0.0f, MovementY);
        rb.AddForce(movement * speed);
    }
}
