using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void tryAgain()
    {
        SceneManager.LoadScene("area51");
    }
    public void leavepussy()
    {
        Application.Quit();
    }
}
