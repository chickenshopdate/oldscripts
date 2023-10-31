using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT_PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);
        Walk(dir);
    }

    private void Walk(Vector2 dir)
    {
      player.velocity = (new Vector2(dir.y * speed, player.velocity.y));
      player.velocity = (new Vector2(dir.x * speed, player.velocity.x));
    }

}
