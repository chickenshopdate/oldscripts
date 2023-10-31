using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Rigidbody2D rb;
  public float speed = 10;

  public float jumpForce;

  public bool isJumping;

  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
      float x = Input.GetAxis("Horizontal");
      float y = Input.GetAxis("Vertical");
      Vector2 dir = new Vector2(x, y);

      Walk(dir);

      if (Input.GetButtonDown("Jump") && isJumping == false)
      {
        rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        Debug.Log("jump");
      }

    }

    private void Walk(Vector2 dir)
    {
      rb.velocity = (new Vector2(dir.x * speed, rb.velocity.y));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject.CompareTag("Ground"))
      {
        isJumping = false;
      }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
      if(other.gameObject.CompareTag("Ground"))
      {
        isJumping = true;
      }
    }
}
