using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingControl : MonoBehaviour
{
    public Rigidbody PushingRB;

    public KeyCode PushButton;

    void Update()
    {
        if (Input.GetKey(PushButton)) 
        {

            PushingRB.AddForce(-Vector3.up*40);
        }
    }
}
