using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonevent : MonoBehaviour
{
    public void loadArea()
    {
        SceneManager.LoadScene("area51");
    }
    public void quit()
    {
        Application.Quit();
    }
}
