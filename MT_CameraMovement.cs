﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT_CameraMovement : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y + 3.5f, -1);
    }
}
