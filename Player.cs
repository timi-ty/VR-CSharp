 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject questionBoard;
    TextMeshProUGUI question;
    TextMeshProUGUI option1Text;
    TextMeshProUGUI option2Text;
    Button option1;
    Button option2;
    int progress;
    void Start()
    {
        question = questionBoard.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        option1 = questionBoard.transform.GetChild(2).GetComponent<Button>();
        option2 = questionBoard.transform.GetChild(3).GetComponent<Button>();
        option1Text = option1.GetComponentInChildren<TextMeshProUGUI>();
        option2Text = option2.GetComponentInChildren<TextMeshProUGUI>();
        questionBoard.SetActive(false);
    }

    public void WaitForQuestion(){
        Time.timeScale = 0;
        questionBoard.SetActive(true);
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(true);
        questionBoard.transform.position = transform.position + (Camera.main.transform.forward * 20) + (Vector3.up * 5);
        questionBoard.transform.rotation = Camera.main.transform.rotation;
        questionBoard.transform.localScale = new Vector3(-1, 1, 1);

        NextQuestion();
    }

    void NextQuestion(){
        switch(progress){
            case 0:
                question.SetText("A police car behind you is flagging you down. What are you going to do?");
                option1Text.SetText("Pull Over Slowly");
                option2Text.SetText("Keep Driving");
                break;
            case 1:
                question.SetText("The police man is approaching to talk to you, what next?");
                option1Text.SetText("Wait Patiently");
                option2Text.SetText("Make a Break For It");
                break;
        }
    }
    void Update()
    {

    }

    public void pickOptionOne(){
        switch(progress){
            case 0:
            case 1:
                questionBoard.SetActive(false);
                Time.timeScale = 1;
                progress++;
                break;
        }
    }

    public void pickOptionTwo(){
        switch(progress){
            case 0:
                option2.gameObject.SetActive(false);
                question.SetText("Statistic about ignoring policemen");
                break;
            case 1:
                option2.gameObject.SetActive(false);
                question.SetText("Repercussions of resistance");
            break;
        }
    }
}
