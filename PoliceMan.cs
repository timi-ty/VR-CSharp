using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMan : MonoBehaviour
{
    Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        Invoke("WalkToPlayer", 1);
    }

    public void WalkToPlayer()
    {
        mAnimator.SetTrigger("WalkToPlayer");
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag.Equals("Player")){
            mAnimator.SetTrigger("StopAtPlayer");
            Player mPlayer = other.GetComponent<Player>();
            mPlayer.WaitForQuestion();
        }
    }
}
