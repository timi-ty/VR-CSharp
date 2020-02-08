using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoySeller : MonoBehaviour
{
    Animator boyAnimator;
    public Animator girlAnimator;
    void Start()
    {
        boyAnimator = GetComponent<Animator>();

        boyAnimator.SetTrigger("WalkNow");
        girlAnimator.SetTrigger("WalkNow");
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Equals("man4")){
            boyAnimator.SetTrigger("StopNow");
            girlAnimator.SetTrigger("StopNow");
        }
    }

    void Update()
    {
        
    }
}
