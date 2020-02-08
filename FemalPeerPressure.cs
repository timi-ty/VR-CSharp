using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemalPeerPressure : MonoBehaviour
{
    public Player thePlayer;
    void Start()
    {
        Invoke("ConversationPrompt", 3);
        Invoke("ConversationPrompt", 6);
        Invoke("ConversationPrompt", 9);
        Invoke("ConversationPrompt", 12);
    }

    void ConversationPrompt(){
        thePlayer.WaitForQuestion();
    }

    void Update()
    {
        
    }
}
