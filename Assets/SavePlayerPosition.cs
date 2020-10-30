using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePlayerPosition : MonoBehaviour
{

    [SerializeField] private float _doorPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, _doorPos);
            }
        }
    }
}
