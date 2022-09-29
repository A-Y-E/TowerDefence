using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class TowerGround : MonoBehaviour,  IPointerClickHandler
{
    public GameObject tower;
    public GameObject towerTwo;
// Use this for initialization
    void Start () 
    {
        tower = (GameObject) Resources.Load("listTower_1");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject spawnPoint = this.gameObject.transform.GetChild(0).gameObject;
        Instantiate(tower, spawnPoint.transform.position, new Quaternion(0f, 0f, 0f, 0f));
    }
}
