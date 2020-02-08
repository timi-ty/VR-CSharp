using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    Transform holdingItem;
    Transform originalParent;
    Collider palmSpace;
    void Start()
    {
        palmSpace = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag.Equals("Interactable")){
            PickUpItem(other.transform);
        }
    }

    void PickUpItem(Transform item){
        if(holdingItem != null){
            holdingItem.transform.SetParent(originalParent);
        }
        holdingItem = item;
        originalParent = holdingItem.parent;
        holdingItem.SetParent(transform, true);
        holdingItem.position = palmSpace.bounds.center;
    }

    void Update()
    {
        
    }
}
