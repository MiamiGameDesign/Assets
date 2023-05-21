using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A simple class that allows for a player to move in any direction.
 */
public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
    }
}