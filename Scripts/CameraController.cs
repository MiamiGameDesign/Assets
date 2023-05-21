using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A simple class that allows for first person camera movement.
 */
public class CameraController : MonoBehaviour
{
    public Transform player;
    float cameraVerticalRotation = 0f;
    void Start()
    {
        //lock and hide the cursor, can remove if you want
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked
    }

    void Update()
    {
        float inputX = Input.GetAxis("Mouse X");
        float inputY = Input.GetAxit("Mouse Y");
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f); //change -90 and 90 to 0 if you don't want the player to able to look up or down
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
        player.rotate(Vector3.up * inputX);
    }
}