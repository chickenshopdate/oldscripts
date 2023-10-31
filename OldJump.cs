using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;

    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown ("Jump"))
      {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
      }  
    }

    //private void Jump()
      //{
        //rb.velocity = new Vector2(rb.velocity.x, 0);
        //rb.velocity += Vector2.up * jumpForce;
      //}
}
