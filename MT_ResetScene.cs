using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MT_ResetScene : MonoBehaviour
{
    //[SerializeField] string scenePlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene("Directions");
        }
    }


}
