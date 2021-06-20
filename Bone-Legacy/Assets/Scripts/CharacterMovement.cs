using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool sprint = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Sprint"))
        {
            sprint = true;
            
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            sprint = false;
        }

        if (Input.GetButtonDown("Summon"))
        {
            if(GameObject.FindWithTag("Skull") != null)
            {
                controller.Summon();
                Destroy(GameObject.FindWithTag("Skull"));
            }        
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, sprint);
    }
}
