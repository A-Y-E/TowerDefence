using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class TowerGround : MonoBehaviour,  IPointerClickHandler
{
    public GameMode gameMode;

    public GameObject tower;
    public GameObject towerTwo;

// Use this for initialization
    void Start () 
    {
        tower = (GameObject) Resources.Load("Turrel");
        
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (gameMode.Diamonds >= tower.GetComponent<InfoTower>().Value.Cost)
        {
            gameMode.Diamonds -= tower.GetComponent<InfoTower>().Value.Cost;
            GameObject spawnPoint = this.gameObject.transform.GetChild(0).gameObject;
            Instantiate(tower, spawnPoint.transform.position, new Quaternion(0f, 0f, 0f, 0f));
        }
    }
}
