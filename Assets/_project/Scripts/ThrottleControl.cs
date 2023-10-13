using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrottleControl : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Adjust the rotation speed as needed
    public float minRotation = -45.0f; // Minimum rotation angle
    public float maxRotation = 45.0f;  // Maximum rotation angle

    private float currentRotation = 0.0f;

    void Update()
    {
        // Increase throttle (rotate forward) when the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentRotation = Mathf.Clamp(currentRotation + rotationSpeed * Time.deltaTime, minRotation, maxRotation);
        }

        // Decrease throttle (rotate backward) when the down arrow key is pressed
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentRotation = Mathf.Clamp(currentRotation - rotationSpeed * Time.deltaTime, minRotation, maxRotation);
        }

        // Update the rotation of the throttle control element within the spaceship
        transform.localRotation = Quaternion.Euler(currentRotation, 0, 0);
    }
}
