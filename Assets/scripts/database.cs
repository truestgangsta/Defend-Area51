using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class database : MonoBehaviour
{
    public Text moneytxt;
    public Text damage;
    public Text bulletGainTxt;
    public bool lockedInMenu;

    //data like bullets and money
    public float Money = 1000;
    public float bullets1 = 100;
    public float bullets2 = 7;
    public float health = 100;
    public float bulletGain = 1;

    //skills
    public float healthUp = 10;
    public float damageUp = 5;

    //enemy stats
    public float wave = 1;
    float oldWave;
    public float moneyDrop = 50;
    public float enemyHealth;
    public float enemyDamage;
    public float enemyCount;
    public float currentlyAlive;

    void Start()
    {
        oldWave = wave;        
    }
    void Update()
    {
        moneytxt.text = Money + "$";
        bulletGainTxt.text = bulletGain + "/press";

        if(oldWave < wave)
            oldWave = wave;

        damage.text = "Current damage: " + damageUp;
    }
}
