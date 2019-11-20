using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Controls controller;
    float horizontalMove;
    bool jump = false;
    public float runSpeed = 100f;

    public Animator animator;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetKeyDown(KeyCode.Space))
            jump = true;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        
    }

   void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
