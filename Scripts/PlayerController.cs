using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A simple class that allows for a player to move in any direction.
 * You need to add a Character Controller component to your player for this to work,
 * and a Rigidbody component (that has rotation in all directions frozen)
 * if you want to apply gravity or to add jumping implementation.
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