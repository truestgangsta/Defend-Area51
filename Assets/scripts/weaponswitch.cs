using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponswitch : MonoBehaviour
{
    public Text bulletstxt;
    public GameObject weapon1;
    public GameObject weapon2;
    public database dbase;
    public int slot = 2;
    bool unlocked = false;
    
    public void unlockLMG(bool unlock)
    {
        if (unlock == true)
            unlocked = true;
    }
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            slot--;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            slot++;
        }
//        slot = Mathf.Clamp(slot, 1, 2);

        switch (slot)
        {
            case 1:
                if (unlocked == true)
                {
                    bulletstxt.text = "Bullets: " + dbase.bullets1;
                    weapon2.SetActive(false);
                    weapon1.SetActive(true);
                }
                else
                    slot = 2;
                break;
            case 2:
                bulletstxt.text = "Bullets: " + dbase.bullets2;
                weapon2.SetActive(true);
                weapon1.SetActive(false);
                break;
            default:
                if (slot > 2)
                    slot = 1;
                else if(slot < 1)
                    slot = 2;
                break;
        }
    }
}
