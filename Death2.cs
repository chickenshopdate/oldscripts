using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death2 : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //you have to drag the scene in build in File->BuildSettings
        if(other.gameObject.CompareTag("Player"))
            { 
                SceneManager.LoadScene("DieScene");
            }

        if(other.gameObject.CompareTag("balloon"))
            { 
                SceneManager.LoadScene("DieScene");
            }

        //don’t forget to put restart in Input Settings
        if (Input.GetButtonDown("restart")) 
            { 
                SceneManager.LoadScene("SampleScene");
                Player.transform.position = startPoint.transform.position;
            } 
    }

}
