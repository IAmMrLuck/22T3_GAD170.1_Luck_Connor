using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace WriteYourNameHere
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.
        [SerializeField] private SpriteRenderer spriteRenderer; // Our character's sprite.

        [SerializeField] private Rigidbody2D rbody2D;
        [SerializeField] private float runSpeed = 3f;
        [SerializeField] private float jumpStrength = 5f;

        private float xInput = 0f;
        private bool isJumping = false;

        private void Start()
        {
            rbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            xInput = Input.GetAxisRaw("Horizontal");
            isJumping = Input.GetKeyDown(KeyCode.Space);

            transform.position += new Vector3(xInput * runSpeed, 0, 0) * Time.deltaTime;

            if (isJumping)
            {
                rbody2D.velocity = Vector2.up * jumpStrength;
            }


            // TODO Movement Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO Movement Bonus 1: Ensure that our character can only jump if they are "grounded". (Hint: You can use a boolean as a part of this!)

            // TODO Movement Bonus 2: Flip our character's sprite so that it faces left/right if we are moving left/right. (Hint: A SpriteRenderer reference, and changing its FlipX = true/false will help!)

        }
    }
}
