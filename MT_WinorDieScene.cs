using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MT_WinorDieScene : MonoBehaviour
{
    [SerializeField] string sceneWin;
    [SerializeField] string sceneDie;
     
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Finish")) {
            SceneManager.LoadScene(sceneWin);
        }
        else
        {
            SceneManager.LoadScene(sceneDie);
            CarverWare.NextGame(false);
        }
    }
}
