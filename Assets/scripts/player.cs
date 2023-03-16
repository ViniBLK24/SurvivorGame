using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float velocity = 10f;
   private Rigidbody rb;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal")* Time.deltaTime * velocity;
        float moveZ = Input.GetAxis("Vertical")* Time.deltaTime * velocity;

        if (moveX != 0 || moveZ != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else if (moveX == 0 && moveZ == 0)
        {
            animator.SetBool("isWalking", false);
        }
        transform.Translate(moveX, 0, moveZ);


    }
} 
