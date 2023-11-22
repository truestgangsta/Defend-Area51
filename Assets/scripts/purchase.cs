using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class purchase : MonoBehaviour
{
    public GameObject buyl;
    public database dbase;
    public weaponswitch switcher;
    public AudioSource weapon;

    public void buyLMG()
    {
        if(dbase.Money >= 15000)
        {
            dbase.Money -= 15000;
            switcher.unlockLMG(true);
            buyl.SetActive(false);
            weapon.Play();
        }
    }
    public void buyHealth()
    {
        if(dbase.Money >= 50)
        {
            dbase.health += dbase.healthUp;
            dbase.Money -= 50;
        }
    }
    public void buyDamage()
    {
        if (dbase.Money >= 50)
        {
            dbase.damageUp += 5;
            dbase.Money -= 50;
        }
    }
    public void buyBullets()
    {
        if (dbase.Money >= 500)
        {
            dbase.bulletGain++;
            dbase.Money -= 500;
        }
    }
}
