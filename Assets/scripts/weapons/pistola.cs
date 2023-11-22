using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class pistola : MonoBehaviour
{
    [SerializeField] Image img;
    [SerializeField] enemyAI enemy;
    GameObject objectG;
    public database dbase;
    public AudioSource source;
    public GameObject fire;

    void Start()
    {
        img = gameObject.GetComponent<Image>();
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && dbase.lockedInMenu == false && dbase.bullets2 != 0)
        {
            fire.SetActive(true);
            dbase.bullets2--;
            
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
                catch { }
            }
        }
        else
        {
            float time = 0;
            time += Time.time; 

            if(time > 2)
            {
                fire.SetActive(false);
                time = 0;
            }
        }
    }
}
