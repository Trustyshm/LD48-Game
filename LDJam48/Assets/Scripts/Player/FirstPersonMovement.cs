using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{

    private CharacterController controller;

    public float moveSpeed = 15f;
    public bool isActive;

    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        if (isActive)
        {
            moveDirection = transform.right * xInput + transform.forward * zInput;
        }

        

        
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
       
        
    }
}
