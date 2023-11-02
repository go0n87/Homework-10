using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    public GameObject Blocker;
    public void Activate()
    {
        Blocker.SetActive(false);
    }

}
