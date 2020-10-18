using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZagMoveCTRL : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //setting MoveKeyPressed Bool
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("MostRecentPress", 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("MostRecentPress", 2);
        }
        else
        {
            animator.SetInteger("MostRecentPress", 1);
        }
    }
}
