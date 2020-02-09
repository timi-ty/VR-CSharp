 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    SceneDataAccesor sceneData;
    string sceneName;
    void Start()
    {
        question = questionBoard.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        option1 = questionBoard.transform.GetChild(2).GetComponent<Button>();
        option2 = questionBoard.transform.GetChild(3).GetComponent<Button>();
        option1Text = option1.GetComponentInChildren<TextMeshProUGUI>();
        option2Text = option2.GetComponentInChildren<TextMeshProUGUI>();
        questionBoard.SetActive(false);

        sceneData = new SceneDataAccesor();
        if(sceneData == null){
            throw new UnityException("The scene name must be present in scene data");
        }
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void WaitForQuestion(){
        Time.timeScale = 0;
        questionBoard.SetActive(true);
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(true);
        questionBoard.transform.position = transform.position + (Camera.main.transform.forward * 20) + Vector3.up;
        questionBoard.transform.rotation = Camera.main.transform.rotation;
        questionBoard.transform.localScale = new Vector3(-1, 1, 1);

        NextQuestion();
    }

    void NextQuestion(){
        question.SetText(sceneData.GetSceneData(sceneName, progress).question);
        option1Text.SetText(sceneData.GetSceneData(sceneName, progress).option1);
        option2Text.SetText(sceneData.GetSceneData(sceneName, progress).option2);
    }
    void Update()
    {

    }

    public void pickOptionOne(){
        if(!option1Text.GetParsedText().Equals("Continue")){
            option2.gameObject.SetActive(false);
            question.SetText(sceneData.GetSceneData(sceneName, progress).successExplanation);

            option1Text.SetText("Continue");
        }
        else{
            questionBoard.SetActive(false);
            progress++;
            Time.timeScale = 1;


            if(SceneDataAccesor.previousScene != null &&
                SceneDataAccesor.previousScene.Equals(SceneManager.GetActiveScene().name)){
                SceneManager.LoadScene("Transition Scene");
            }
        }
    }

    public void pickOptionTwo(){
        option2.gameObject.SetActive(false);
        question.SetText(sceneData.GetSceneData(sceneName, progress).failureExplanation);

        option1Text.SetText("Continue");
    }
}
