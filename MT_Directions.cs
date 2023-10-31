using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MT_Directions : MonoBehaviour
{
    double countdown;
    double interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        countdown = 4;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < interval) 
        {
            countdown = 0;
            SceneManager.LoadScene("NeighboorhoodDrive");
        }
    }
}
