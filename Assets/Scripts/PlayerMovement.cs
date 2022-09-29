using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float horizontal;
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    private bool isFacingRight = true;
    private Rigidbody2D rb;
    [SerializeField] Transform rightFeet , leftFeet;
    [SerializeField] LayerMask groundLayer;


    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        flip();

        bool jump = Input.GetButtonDown("Jump");
        if(jump && isGrounded()) {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

    }
    private void FixedUpdate() {
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, rb.velocity.y);
    }
    private void flip() {
        if(isFacingRight && horizontal < 0 || !isFacingRight && horizontal > 0){
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
    private bool isGrounded() {
        return Physics2D.OverlapCircle(leftFeet.position, .2f, groundLayer) 
            || Physics2D.OverlapCircle(rightFeet.position, .2f, groundLayer);
    }
}
