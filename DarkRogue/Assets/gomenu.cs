using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomenu : MonoBehaviour
{
    private bool isEnding = false;

    private void Update()
    {
        if (isEnding && Input.GetKeyDown(KeyCode.KeypadEnter))
            SceneManager.LoadScene(0);
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (isEnding && Input.GetKeyDown(KeyCode.KeypadEnter))
    //        SceneManager.LoadScene(0);
    //}

    void Ending()
    {
        isEnding = true;
    }
}
