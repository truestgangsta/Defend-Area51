using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lmg : MonoBehaviour
{
    [SerializeField]Image img;
    [SerializeField]enemyAI enemy;
    GameObject objectG;
    public GameObject fire;
    public database dbase;
    public AudioSource source;
    float nextFire = 0f;
    float fireRate = 0.01f;

    void Start()
    {
        img = gameObject.GetComponent<Image>();
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0) && (Time.time / 10) > nextFire && dbase.lockedInMenu == false && dbase.bullets1 != 0)
        {
            nextFire = (Time.time / 10) + fireRate;
            fire.SetActive(true);
            dbase.bullets1--;
            if(source.isPlaying == false)
                source.Play();
            if (Physics.Raycast(ray, out hit))
            {
                try
                {
                    objectG = hit.transform.gameObject;
                    enemy = objectG.GetComponent<enemyAI>();
                    enemy.health -= dbase.damageUp;
                    dbase.Money += 25;
                }
                catch {  }
            }
        }
        else
        {
            fire.SetActive(false);
        }
    }
}
