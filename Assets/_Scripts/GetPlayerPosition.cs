using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetPlayerPosition : MonoBehaviour
{
    private string _currentPos;

    // Start is called before the first frame update
    void Start()
    {
        _currentPos = PlayerPrefs.GetString("PlayerPos");
        
        if (_currentPos == "Right")
        {
            transform.position = DoorPositionController._one.transform.position;
        }
        else if (_currentPos == "Left")
        {
            transform.position = DoorPositionController._two.transform.position;
        }
    }
}