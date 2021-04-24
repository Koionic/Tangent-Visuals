using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class Move : MonoBehaviour
{
    [SerializeField]
    [Range(0f,200f)]
    float moveSpeed;

    [SerializeField]
    [Range(0f, 200f)]
    float rollSpeed;

    [SerializeField]
    [Range(0f, 200f)]
    float lookSpeed;

    [SerializeField]
    [Range(0f, 200f)]
    float upDownSpeed;

    [SerializeField]
    float autoMoveSpeed = 0f;
    bool autoMove = false;

    [SerializeField]
    float autoLookSpeed = 0f;
    bool autoLook = false;

    Vector2 leftJoystickInput = Vector2.zero;
    Vector2 rightJoystickInput = Vector2.zero;

    public Vector3 LeftJoystick
    {
        get { return leftJoystickInput; }
    }

    public Vector3 RightJoystick
    {
        get { return rightJoystickInput; }
    }

    public float TriggersInput
    {
        get { return triggersInput; }
    }

    float triggersInput = 0f;

    float upDownInput = 0f;

    [SerializeField]
    float autoMoveDelay = 3f;

    float delayTimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") != 0)
        //{
        //    transform.Rotate(transform.forward, -Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        //}

        //if (Input.GetAxis("Vertical") != 0)
        //{
        //    speed += Input.GetAxis("Vertical") * Time.deltaTime;
        //}

        delayTimer -= Time.deltaTime;

        if(delayTimer <= 0f)
        {
            autoLook = true;
            autoMove = true;
        }

        leftJoystickInput = autoMove ? new Vector2((Mathf.PerlinNoise(0f, Time.time) * 2) - 1, (Mathf.PerlinNoise(Time.time, 0f) * 2) - 1) : leftJoystickInput;

        //Move camera forward
        transform.position += (transform.forward * (autoMove ? autoMoveSpeed : leftJoystickInput.y)) * Time.deltaTime * moveSpeed;

        //Move camera right
        transform.position += (transform.right * leftJoystickInput.x) * Time.deltaTime * moveSpeed;

        //Free Look Camera
        transform.Rotate(new Vector3(-rightJoystickInput.y, rightJoystickInput.x, 0) * lookSpeed);

        //Barrel Roll Camera
        transform.Rotate(Vector3.forward, (autoLook ? autoLookSpeed : triggersInput) * Time.deltaTime * rollSpeed);

        //Move Camera up and down
        transform.position += (transform.up * upDownInput) * Time.deltaTime * upDownSpeed;
    }

    public void RightJoystickMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();

        rightJoystickInput = input;

        if (input != Vector2.zero)
        {
            autoLook = false;
        }

        ResetTimer();
    }

    public void LeftJoystickMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();

        leftJoystickInput = input;

        if (input != Vector2.zero)
        {
            autoMove = false;
        }

        ResetTimer();
    }

    public void LeftAndRightTriggers(InputAction.CallbackContext context)
    {
        float input = context.ReadValue<float>();

        triggersInput = input;

        ResetTimer();
    }

    public void LeftJoystickClick(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            print("left clicky");
            autoMove = !autoMove;

            ResetTimer();
        }
    }

    public void RightJoystickClick(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            print("right clicky");
            autoLook = !autoLook;

            ResetTimer();
        }
    }

    public void UpAndDown(InputAction.CallbackContext context)
    {
        float input = context.ReadValue<float>();

        upDownInput = input;

        ResetTimer();
    }

    void ResetTimer()
    {
        delayTimer = autoMoveDelay;
    }
}
