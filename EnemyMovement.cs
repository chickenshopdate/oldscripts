using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float RotateSpeed = 1f;
    private float Radius = 6f;

    private Vector2 _centre;
    private float _angle;

    public GameObject enemy;
    public GameObject balloon;
    
    // Start is called before the first frame update
    void Start()
    {
        _centre = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.transform.position.x <= balloon.transform.position.x + 10)
        {
            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            transform.position = _centre + offset;

        }

        if (enemy.transform.position.y >= 8)
        {
            enemy.transform.position = new Vector2(-3, 7);
        }
    }
}
