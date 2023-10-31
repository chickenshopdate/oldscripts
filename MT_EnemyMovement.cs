using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT_EnemyMovement : MonoBehaviour
{
    public Rigidbody2D sideCar;
    public Rigidbody2D trashbin;
    public float speed = -5;
    public float driveSpeed;
    public Rigidbody2D driving;
    public Rigidbody2D player;
    public Rigidbody2D trashbin2;
    //float randomY;

    [SerializeField] GameObject[] objectsToIgnore;

    // Start is called before the first frame update
    void Start()
    {
        driveSpeed = -10;
        sideCar.velocity = new Vector2(0f, speed);
        trashbin.velocity = new Vector2(0f, speed);
        trashbin2.velocity = new Vector2(0f, speed);
        driving.velocity = new Vector2(0f, driveSpeed);
        sideCar.transform.position = new Vector2(player.transform.position.x, 20f);
        for(int i=0; i < objectsToIgnore.Length; i++)
        {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), objectsToIgnore[i].GetComponent<Collider2D>());
        }
        //randomY = Random.Range(-0.75f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (sideCar.transform.position.y <= -8) {
            sideCar.transform.position = new Vector2(player.transform.position.x, 28.5f);
        }
        if (trashbin.transform.position.y <= -8) {
            trashbin.transform.position = new Vector2(Random.Range(-7.5f, -5f), 32f);
        }
        if (trashbin2.transform.position.y <= -8) {
            trashbin2.transform.position = new Vector2(Random.Range(1f, 5f), 35f);
        }
        if (driving.transform.position.y <= -8) {
            driving.transform.position = new Vector2(-4.75f, 29f);
        if (trashbin.transform.position.x == driving.transform.position.x)
        {
            trashbin.transform.position = new Vector2(trashbin.transform.position.x - 1.5f, trashbin.transform.position.y);
        }
        if (trashbin2.transform.position.x == driving.transform.position.x)
        {
            trashbin2.transform.position = new Vector2(trashbin2.transform.position.x + 1.5f, trashbin2.transform.position.y);
        }
        }
        driving.transform.position = new Vector2(driving.transform.position.x + 0.00195f, driving.transform.position.y);
    }
}
