using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    database dbase;
    public float health = 35;
    public Transform goToPoint;
    public GameObject based;
    GameObject soundfind;
    AudioSource hitsound;
    float damage = 5;
    float nextDamage;
    float damageRate = 2;

    void Start()
    {
        soundfind = GameObject.Find("hit");
        based = GameObject.Find("Database");
        dbase = based.GetComponent<database>();
        hitsound = soundfind.GetComponent<AudioSource>();
    }
    void Update()
    {
        Vector3 playerPos = new Vector3(transform.position.x, 3.23f, transform.position.z);
        Vector3 goTo = new Vector3(goToPoint.position.x, 3.23f, goToPoint.position.z);
        transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.y, 0);

        if (health <= 0)
        {
            Destroy(gameObject);
            dbase.Money += dbase.moneyDrop;
        }

        transform.position = Vector3.MoveTowards(playerPos, goTo, 0.035f);
        if (playerPos == goTo && Time.time > nextDamage)
        {
            nextDamage = Time.time + damageRate;
            dbase.health -= damage;
            if (hitsound.isPlaying == false)
                hitsound.Play();
        }
    }
}
