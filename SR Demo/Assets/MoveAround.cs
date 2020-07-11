using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    [Range(0f, 10f)]
    public float speed = 10f;
    public float gravity = -9.81f;
    Vector3 velocity;
    bool isGrounded;

    public CharacterController charController;
    public Transform groundCheckTransform;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    [Range(0f, 5f)]
    public float jumpHeight = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheckTransform.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        Vector3 movement = transform.right * x + transform.forward * z;

        charController.Move(movement * speed * Time.deltaTime);

        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        charController.Move(velocity * Time.deltaTime);

    }
}
