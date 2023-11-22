using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    float sens = 2;
    float mouseY;
    bool unlocked = false;
    public GameObject menu;
    public Text txt;
    public AudioSource source;
    public database data;
    public Text health;
    public weaponswitch switcher;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }
    void Update()
    {
        health.text = "Health: " + data.health;
        if (Input.GetKeyDown(KeyCode.B))
        {
            if(source.isPlaying == false)
                source.Play();

            switch(switcher.slot)
            {
                case 1:
                    data.bullets1 += data.bulletGain;
                    data.bullets1 = Mathf.Clamp(data.bullets1, 0, 100);
                    break;
                case 2:
                    data.bullets2 += data.bulletGain;
                    data.bullets2 = Mathf.Clamp(data.bullets2, 0, 7);
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (unlocked == false)
            {
                data.lockedInMenu = true;
                unlocked = true;
                txt.text = "Press escape again to resume";
                menu.SetActive(true);
            }
            else
            {
                data.lockedInMenu = false;
                unlocked = false;
                txt.text = "Press escape for the menu";
                menu.SetActive(false);
            }
        }

        if (data.health <= 0)
            SceneManager.LoadScene("dead");

        if(unlocked == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            mouseY += Input.GetAxis("Mouse X") * sens;
            mouseY = Mathf.Clamp(mouseY, -53, 53);
            transform.rotation = Quaternion.Euler(0, mouseY, 0);        
        }
        else
            Cursor.lockState = CursorLockMode.None;
    }
}
