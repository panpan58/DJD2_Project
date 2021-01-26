﻿using UnityEngine.UI;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = default;

    [SerializeField] private Transform playerBody = default;
    [SerializeField] private Slider slider = default;

    private float xRotation = 0f;

    // Start is called before the first frame update
    private void Start()
    {
        // Lock cursor in game window (press ESC to see cursor)
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        // Gets X and Y angle axis
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity *
            Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity *
            Time.deltaTime;

        //Rotates player vision in Y axis and limits the rotation in 80 and 
        // -80 degrees
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //Rotates player body with the X camera axis
        playerBody.Rotate(Vector3.up * mouseX);
    }

    public void MouseSensibility()
    {
        mouseSensitivity = slider.value;
    }
}
