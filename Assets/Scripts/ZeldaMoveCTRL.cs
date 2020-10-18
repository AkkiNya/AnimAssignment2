using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeldaMoveCTRL : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //setting CrouchKeyPressed Bool
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("CrouchKeyPressed", true);
        }
        else
        {
            animator.SetBool("CrouchKeyPressed", false);
        }

        //setting MoveKeyPressed Bool
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("MoveKeyPressed", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("MoveKeyPressed", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("MoveKeyPressed", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("MoveKeyPressed", true);
        }
        //if no movement key is pressed, set movement to false
        else
        {
            animator.SetBool("MoveKeyPressed", false);
        }

        //setting SprintKeyPressed Bool
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("SprintKeyPressed", true);
        }
        else
        {
            animator.SetBool("SprintKeyPressed", false);
        }
    }
}
