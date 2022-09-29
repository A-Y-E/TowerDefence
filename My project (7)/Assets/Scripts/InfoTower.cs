using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfoTower : MonoBehaviour
{
    public Tower Value = new Tower();

    private GameObject target;
    private float reloads;
    private bool attack = false;
    private GameObject bullet;

    private GameMode gameMode;

    void Start()
    {
        gameMode = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameMode>();
        reloads = Value.atkSpeed;
    }

    void Update()
    {
        if(attack)
        {
            if(target != null)
            {
                if(Vector3.Distance(transform.position, target.transform.position) <= Value.Range)
                {   
                    if(reloads <= 0.0f)
                    {
                        bullet = (GameObject)Instantiate(Value.BulletPref,  this.gameObject.transform.Find("BulletSpawn").gameObject.transform.position, Quaternion.identity);
                        bullet.GetComponent<Bullet>().Target = target;
                        bullet.GetComponent<Bullet>().Damage = Value.Damage;
                        bullet.GetComponent<Bullet>().Speed = Value.bitSpeed;
                        reloads = Value.atkSpeed;
                    }else
                    {
                        reloads -= Time.deltaTime;
                    }
                }else
                {
                    attack = false;
                }
            }else
            {
                attack = false; 
            }
        }else
        {
            foreach(GameObject obj in gameMode.GameUnits)
            {
                if(Vector3.Distance(transform.position, obj.transform.position) <= Value.Range)
                {
                    target = obj;
                    attack = true;
                }
            }
        }
    }
}
