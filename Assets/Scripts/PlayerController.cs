using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed=5.0f;
    private Rigidbody2D playerRB;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if(horizontalInput != 0){
            spriteRenderer.flipX = horizontalInput>0;
        }
        animator.SetFloat("speed", Mathf.Abs(horizontalInput));

        Vector2 Move = new Vector2(horizontalInput, verticalInput).normalized;
        playerRB.linearVelocity = Move*speed;
        
    }
}
