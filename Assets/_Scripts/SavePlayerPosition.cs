using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SavePlayerPosition : MonoBehaviour
{
    private bool isColliding;
    private DoorVariables _dorVar;


    private void Start()
    {
        PlayerPrefs.SetString("PlayerPos", "Right");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            isColliding = true;
            _dorVar = collision.transform.GetComponent<DoorVariables>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isColliding = false;
    }

    void OnInteract()
    {
        if (isColliding)
        {
            Debug.Log("Is this working?");
            PlayerPrefs.SetString("PlayerPos", _dorVar._doorPos);
            SceneManager.LoadScene(_dorVar._sceneName);
        }
    }
}