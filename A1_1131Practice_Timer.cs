using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A1_1131Practice_Timer : MonoBehaviour
{
    [SerializeField] float interval = 1f;
    GameObject timerObj;
    Text timerDisplayText;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        timerObj = GameObject.Find("Text");
        timerDisplayText = timerObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerDisplayText.text = timer.ToString("F0");
        if (timer > interval)
        {
            //do something
            timer = 0;
        }

        //----------------------------------------------------------------------------
        //Doing some simple movements

        if (Input.GetAxis("MoveX") > 0)
        {

        }
    }
}
