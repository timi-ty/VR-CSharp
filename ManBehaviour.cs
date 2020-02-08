using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManBehaviour : MonoBehaviour
{
    Animator mAnimator;
    public Player thePlayer;
    void Start()
    {
       mAnimator = GetComponent<Animator>();
       mAnimator.SetTrigger("WalkNow");
       Invoke("Prompt", 2);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Equals("MeetPoint")){
            mAnimator.SetTrigger("StopNow");
            Prompt();
            Invoke("Grab", 0.5f);
        }
    }

    void Prompt(){
        thePlayer.WaitForQuestion();
    }

    void Grab(){
        mAnimator.SetTrigger("GrabNow");
        Invoke("Prompt", 5);
    }


    void Update()
    {
        
    }
}
