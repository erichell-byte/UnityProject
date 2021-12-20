using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private CharacterController MyController;
    Transform MyTransform;

    public float Speed = 5;

    public float JumpSpeed = 2;

    public float Gravity = 10;

    //public float Angle = 45;

    //var horizontal = ;
    //var vertical = ;
    //var jump = Input.GetAxis("Jump");

    private Vector3 deltaMove;

    // Start is called before the first frame update
    void Start()
    {
        MyController = GetComponent<CharacterController>();
        MyTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (MyController.isGrounded)
        {
            deltaMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) ;
            deltaMove = deltaMove.normalized;
            deltaMove = transform.TransformDirection(deltaMove);
            if (Input.GetKey(KeyCode.Space))
            {
                deltaMove.y += JumpSpeed;
            }  
        }
        else
        {
            deltaMove.y -= Gravity * Time.deltaTime;
        }
        MyController.Move(deltaMove * Time.deltaTime * Speed);
    }
}
