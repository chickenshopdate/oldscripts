using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT_PedestrainMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D player;
    [SerializeField] GameObject[] objectsToIgnore;
    //public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector2(speed, 0f);
        for(int i=0; i < objectsToIgnore.Length; i++)
        {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), objectsToIgnore[i].GetComponent<Collider2D>());
        }
        rb.transform.position = new Vector2(9.5f, rb.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.x <= -9) {
            rb.transform.position = new Vector2(9.5f, 10f);
        }
        rb.transform.position = new Vector2(rb.transform.position.x - 0.01f, rb.transform.position.y);
        if (player.transform.position.y >= 8.25f) {
        }
    }

}
