using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MT_Timer : MonoBehaviour
{
    [SerializeField] double interval = 1;
    GameObject timerObj;
    Text timerDisplayText;
    double timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = CarverWare.timeLeft;
        timerObj = GameObject.Find("timerTXT");
        timerDisplayText = timerObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerDisplayText.text = timeLeft.ToString("F1");
        if (timeLeft < 0)
        {
            //do something
            timeLeft = 0;
            SceneManager.LoadScene("DieScene");
            CarverWare.NextGame(false);
        }
    }
}
