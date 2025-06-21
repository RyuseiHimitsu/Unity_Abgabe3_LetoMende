using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region Defining

    private float direction;
    public Rigidbody2D rb;
    public float speed = 2f;
    public float jumpForce = 16f;
    public float horizontal;
    public bool isFacingRight = true;
    public UIManager uiManager;
    public int jumpsRemaining = 1;
    [SerializeField] GameObject groundCheck;
    public float ScaleValue = 3f;
    
    #endregion


    void Update()
    {
        GroundCheck();
        
        horizontal = Input.GetAxis("Horizontal");
        
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        direction = 0;
        
        if (Keyboard.current.dKey.isPressed && uiManager.canMove)
        {
            direction = 5f;
        }
        
        if (Keyboard.current.aKey.isPressed && uiManager.canMove)
        {
            direction = -5f;
        }
        
        // jump
        if (Keyboard.current.spaceKey.isPressed && uiManager.canMove && jumpsRemaining > 0)
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
            jumpsRemaining--;
        }
    }

    void GroundCheck()
    {
        if (Physics2D.OverlapCircle(groundCheck.transform.position, 0.2f, LayerMask.GetMask("Ground")))
        {
            jumpsRemaining = 1;
        }
    }
}
