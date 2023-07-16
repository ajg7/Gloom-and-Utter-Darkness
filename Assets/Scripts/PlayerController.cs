using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GloomAndUtterDarkness.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed = 6.0f;
        [SerializeField] Vector3 moveDirection = Vector3.zero;
        [SerializeField] CharacterController controller;
        [SerializeField] float jumpSpeed = 8.0f;
        [SerializeField] float gravity = 20.0f;

        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection *= speed;

                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }
            }

            // Apply gravity
            moveDirection.y -= gravity * Time.deltaTime;

            // Move the controller
            controller.Move(moveDirection * Time.deltaTime);
        }
    }

}