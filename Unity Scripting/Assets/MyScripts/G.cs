
using System;
using UnityEngine;

public class G : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mousex = Input.GetAxis("Mouse X") + mouseSensitivity + Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") + mouseSensitivity + Time.deltaTime;
        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up*mousex);
    }
}