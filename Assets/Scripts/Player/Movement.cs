using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D playerRB;
    private Vector2 direction = Vector2.right;

    private bool jumped = false;

    public bool reverse = false;


    public float initialJumpForce = 6.0f;
    public float initialMoveSpeed = 5.0f;

    private float jumpForce = 0.0f;
    private float moveSpeed = 0.0f;

    public Transform groundCheck;
    public LayerMask whatIsGround;
    private bool grounded;


    private void Awake() {
        if(reverse) {
            direction = Vector2.left;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }


    }

    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction * moveSpeed * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            Jump();
        }
        IsGrounded();
    }




    public void Jump() {

        if(!jumped) {
            playerRB.velocity = Vector2.up * jumpForce;
            jumped = true;

        }

        jumpForce = initialJumpForce;
        moveSpeed = initialMoveSpeed;

    }


    void IsGrounded() {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, whatIsGround);
        if(grounded) {
            jumped = false;
        }
        if(playerRB.velocity.y > 1) {
            jumped = true;
        }


    }


    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name.Contains("death")) {
            Destroy(gameObject);
            GameManager.Instance.LoadScene("intro");
        }
    }


}
