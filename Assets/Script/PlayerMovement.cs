using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 20f;
    public float gravity = -9.81f;
    public float jumpheight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
 
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        //
        if (Input.GetKeyDown(KeyCode.E))
        {
            BedInteraction();
        }
    
    }

     void BedInteraction()
    {
        
            Vector3 characterPosition = transform.position;
            Vector3 characterForward = transform.forward;

            Ray ray = new Ray(characterPosition, characterForward);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("bed"))
                {
                    PlayerInventory playerInventory = GetComponent<PlayerInventory>();
                    if(playerInventory.NumberOfOyuncak == 6)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                    else
                    {
                        Debug.Log("Oyuncak lazim abe, sendekiler: " + playerInventory.NumberOfOyuncak.ToString());
                    }
                    

                }
            }
    }
}
