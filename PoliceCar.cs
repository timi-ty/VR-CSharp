using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCar : MonoBehaviour
{
    public GameObject thePolice;
    Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        Invoke("StartChasing", 2);
    }

    void StartChasing()
    {
        mAnimator.SetTrigger("DriveNow");
    }

    void FinishChasing()
    {
        PoliceMan mPoliceMan = Instantiate(thePolice, transform.position + Vector3.left*2, Quaternion.Euler(0, 180, 0))
                                .GetComponent<PoliceMan>();
    }

    void Update()
    {
        
    }
}
