using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float sensetivityX = 8f;
    [SerializeField]
    private float sensetivityY = 0.5f;
    [SerializeField]
    private float smoothTime;

    [SerializeField]
    private Transform camera;
    [SerializeField]
    private float xClamp;

    private float xRotation = 0f;

    private float mouseX, mouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;

        targetRotation.x = xRotation;
        camera.eulerAngles = targetRotation;
    }

    public void RecieveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensetivityX;
        mouseY = mouseInput.y * sensetivityY;
    }
}
