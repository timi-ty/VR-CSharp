using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemalPeerPressure : MonoBehaviour
{
    public Player thePlayer;
    void Start()
    {
        Invoke("ConversationPrompt", 3);
        Invoke("ConversationPrompt", 10);
        Invoke("ConversationPrompt", 18);
        Invoke("ConversationPrompt", 28);
    }

    void ConversationPrompt(){
        thePlayer.WaitForQuestion();
    }

    void Update()
    {
        
    }
}
