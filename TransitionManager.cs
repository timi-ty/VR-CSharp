using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TransitionManager : MonoBehaviour
{
    public GameObject questionBoard;
    TextMeshProUGUI question;
    TextMeshProUGUI option1Text;
    TextMeshProUGUI option2Text;
    Button option1;
    Button option2;

    void Start()
    {
        question = questionBoard.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        option1 = questionBoard.transform.GetChild(2).GetComponent<Button>();
        option2 = questionBoard.transform.GetChild(3).GetComponent<Button>();
        option1Text = option1.GetComponentInChildren<TextMeshProUGUI>();
        option2Text = option2.GetComponentInChildren<TextMeshProUGUI>();

        questionBoard.SetActive(true);
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(false);
        questionBoard.transform.position = transform.position + (Camera.main.transform.forward * 20) + Vector3.up;
        questionBoard.transform.rotation = Camera.main.transform.rotation;
        questionBoard.transform.localScale = new Vector3(-1, 1, 1);

        switch(SceneDataAccesor.previousScene){
            case "Cultural Antiques":
                question.SetText("You purchase the tusks online and go to pick them up at the post office. On your way back from the post office, you are flagged down by a police officer.");
                option1Text.SetText("Continue");
                break;
            case "Police Brutality":
                question.SetText("You end up at the station and you are charged with illegal possession of cultural antiquities. The goods in your car were confiscated and your parents come to bail you out.");
                option1Text.SetText("Continue");
                break;
        }
    }

    public void NextScene(){
        switch(SceneDataAccesor.previousScene){
            case "Cultural Antiques":
                SceneManager.LoadScene("Police Brutality");
                break;
            case "Police Brutality":
                SceneManager.LoadScene("Child Abuse");
                break;
        }
    }


    void Update()
    {
        
    }
}
