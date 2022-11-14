using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
//FINISHED - 15/11/22
namespace ConnorLuck
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.
        [SerializeField] private SpriteRenderer spriteRenderer; // Our character's sprite.
        [SerializeField] private BoxCollider2D boxCollider;
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private Rigidbody2D rbody2D; 
        // i've created references to call back to

        [SerializeField] private float runSpeed = 7f; 
        // this and the next, are the starting values of my stats - I'm holding values for running and jumping
        [SerializeField] private float jumpStrength = 3f;

        private void Start()
        {
            rbody2D = GetComponent<Rigidbody2D>();
            boxCollider = GetComponent<BoxCollider2D>();
            // this checks for the component rigidbody2D, and store it in the rbody2D variable
        }

        private void Update()
        {

            float horizontalInput = (Input.GetAxis("Horizontal"));

            rbody2D.velocity = new Vector2(horizontalInput * runSpeed, rbody2D.velocity.y);
            // the value i've used is defined by Unity - and it checks if the directoinal keys (or A,D) are pressed and changes the Horizontal Axis by +1 or -1
            // this however, leaves us with very slow movemet - so that is why i have declared my speed variable above and used "*runspeed"

            if (horizontalInput > 0.01f)
                transform.localScale = Vector3.one;
            else if (horizontalInput < -0.01f)
                transform.localScale = new Vector3(-1, 1, 1);
            // this flips my guy when i run left to right. this can be represented in the inspector using the Scale. 1, he is facing left, and -1 he is facing right
            // i admittedly don't fully understand the (-1, 1, 1) but i know that it works.
            // i also needed to flip this dude in unity so that it would line up correctly with the buttons
            // i also added an animation for his idle state - i didn't think there was enough to add a run animation


            if (Input.GetKeyDown(KeyCode.Space))
                Jump();

            if (Input.GetKeyUp(KeyCode.Space) && rbody2D.velocity.y > 0)
                rbody2D.velocity = new Vector2(rbody2D.velocity.x, rbody2D.velocity.y / 2);

            //this method here prevents the player from holding dowm jump to fly off the screen
            // but it doesn't prevent players from rapidly tapping the button to continue jumping

        }

        private void Jump()
        {
            rbody2D.velocity = new Vector3(rbody2D.velocity.x, runSpeed, jumpStrength);

        }
        // i've added this to optimise my jump method
        // i've also added "runSpeed" here to ensure that my character doesnm't slow down when jumping


        private bool onGround()
        {
            RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
            return raycastHit.collider != null;
            // i found that this was the way to it, but i didn't understand this 
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "SceneTransition")
            {
                SceneLoader.Instance.sceneToMoveTo();
            }

        }

    }
}
