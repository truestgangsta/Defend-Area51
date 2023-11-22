using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class why : MonoBehaviour
{
    float time = 0;
    void Update()
    {
        time = Time.time;
        Debug.Log(time);
        if (time >= 6 || Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("mainmenu");
    }
}
