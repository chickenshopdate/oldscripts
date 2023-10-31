using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need these when manipulating canvases!!!
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    bool startGame = false;
    const float BUTTONMINSIZE = 50f;
    const float BUTTONMAXSIZE = 250f;
    int score;
    Text scoreDisplaytext;
    GameObject scoreObj;

    //when the game ends
   [SerializeField] float endTime = 10f;

   //the thing we're displaying on
    GameObject target;
    Text timerDisplayText;

    //a timer for when the game ends
    float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        target = GameObject.Find("PlayerBTNtext");
        timerDisplayText = target.GetComponent<Text>();
        score = 0;
        scoreObj = GameObject.Find("scoreTXT");
        scoreDisplaytext = scoreObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame == true)
        {
        //Time.deltaTime makes sure we're frame rate independent
            counter += Time.deltaTime;
            timerDisplayText.text = counter.ToString("F0");
            scoreDisplaytext.text = score.ToString();
            if (counter > endTime)
            {
                //do something
                counter = 0;
                ResetGame(); //call
            }
        }

        if (Input.GetButton("Cancel"))
        {
            //this doesn't work in the editor
            Application.Quit();
        }
    }

    private void ResetGame() //definiton
    {
        //Application.Quit();
        UnityEngine.SceneManagement.SceneManager.LoadScene("ButtonGame");
    }

    public void wasClicked()
    {
        startGame = true;

        score += 1;
        //Random.Range(min, max) - return a value between x and y 
        //If x and y are ints then you get back an int

        //Camera.main
        //Camera.main orthographicSize
        float randX = Random.Range(-Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize * Camera.main.aspect);
        float randY = Random.Range(-Camera.main.orthographicSize, Camera.main.orthographicSize);
        transform.position = new Vector3(randX, randY, 0);

        //I want to change the size of the button on each click
        GetComponent<RectTransform>().sizeDelta = new Vector3(Random.Range(BUTTONMINSIZE, BUTTONMAXSIZE), Random.Range(BUTTONMINSIZE, BUTTONMAXSIZE), 1);



        Color randColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f,1f));
        target.transform.parent.GetComponent<Image>().color = randColor;

    }
}
