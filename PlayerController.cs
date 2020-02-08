using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerBody;
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 vertical = Camera.main.transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontal = Camera.main.transform.right * Input.GetAxis("Horizontal");
        Vector3 upward = Vector3.up * 10 * Input.GetAxis("Jump");

        Vector3 locomotiveForce = vertical + horizontal + transform.position;

        Vector3 moveTo = Vector3.MoveTowards(transform.position, locomotiveForce, Time.deltaTime * 5);
        
        playerBody.MovePosition(moveTo);

        playerBody.AddForce(upward);
    }
}
