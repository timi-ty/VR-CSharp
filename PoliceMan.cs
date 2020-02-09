using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMan : MonoBehaviour
{
    Animator mAnimator;
    Player mPlayer;
    Animator playerAnimator;
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
            mPlayer = other.GetComponent<Player>();
            playerAnimator = other.transform.GetChild(1).GetComponent<Animator>();
            StartCoroutine(QueryPlayer(0));
            StartCoroutine(QueryPlayer(3));
            StartCoroutine(QueryPlayer(6));
        }
    }

    IEnumerator QueryPlayer(int wait){
        yield return new WaitForSeconds(wait);
        if(wait == 3){
            playerAnimator.SetTrigger("LeaveCar");
        }
        mPlayer.WaitForQuestion();
        yield return null;
    }
}
