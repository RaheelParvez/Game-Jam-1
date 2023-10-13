using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRotation : MonoBehaviour
{
    public Transform joystick; // The transform of the joystick model
    public float rotationSpeed = 5f; // Adjust the rotation speed as needed

    private Vector3 initialMousePosition;
    private Quaternion initialJoystickRotation;

    private void Start()
    {
        // Store the initial joystick rotation and mouse position
        initialJoystickRotation = joystick.rotation;
        initialMousePosition = Input.mousePosition;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Store the initial mouse position when the left mouse button is pressed
            initialMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            // Calculate the mouse movement delta
            Vector3 mouseDelta = Input.mousePosition - initialMousePosition;

            // Calculate the rotation angles based on mouse movement
            float rotationX = -mouseDelta.y * rotationSpeed * Time.deltaTime;
            float rotationY = mouseDelta.x * rotationSpeed * Time.deltaTime;

            // Apply the rotation to the joystick
            joystick.rotation = initialJoystickRotation * Quaternion.Euler(rotationX, rotationY, 0f);

            // Update the initial mouse position for the next frame
            initialMousePosition = Input.mousePosition;
        }
    }
}
