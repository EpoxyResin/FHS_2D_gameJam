using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("object entered the trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("object is within trigger"); 
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("object Exited the trigger");
    }
}
