using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCTRL : MonoBehaviour
{
    public Animator animator;
    private float InputX;
    private float InputY;

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
        else
        {
            animator.SetBool("MoveKeyPressed", false);
        }
    }
}
