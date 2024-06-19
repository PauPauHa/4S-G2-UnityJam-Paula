using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using Vector2 = UnityEngine.Vector2;

public class Movment : MonoBehaviour
{
    private Vector2 inputVector;
    public Rigidbody2D rb;
    private BoxCollider2D box; 
    private float mSpeed = 10f;
    private float jumpSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    public void OnMove(InputValue inputValue)
    {
        inputVector = inputValue.Get<Vector2>();
    }

    public void OnJump()
    {
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
      
        Debug.Log("jump");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(inputVector.x * mSpeed, rb.velocity.y);
        
        rb.velocity = moveDirection;
    }
}
