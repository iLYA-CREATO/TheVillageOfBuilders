using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaneraMove : MonoBehaviour
{
    public float panSpeed = 20f;

    private bool doMovement = false;

    Vector3 lastMousePosition;


    public void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            doMovement = true;
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(1))
        {
            doMovement = false;
        }

        if (doMovement)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            Vector3 moveDirection = new Vector3(delta.x, delta.y, 0f);
            Vector3 globalMoveDirection = transform.TransformDirection(moveDirection);
            transform.Translate(globalMoveDirection * panSpeed * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }
    }
}
