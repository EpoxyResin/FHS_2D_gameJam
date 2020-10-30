using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPositionController : MonoBehaviour
{
    [SerializeField] public static GameObject _one;
    [SerializeField] public static GameObject _two;

    private void Awake()
    {
        _one = GameObject.Find("WestDoor");
        _two = GameObject.Find("EastDoor");
    }
}