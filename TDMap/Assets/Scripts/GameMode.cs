using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public int Diamonds = 20;
    public int LosesUnits = 0;
    public int CoutWave;
    public int CurWave;

    /* public List<GameObject> shopTowers = new List<GameObject>();
    public List<GameObject> buttonTowers = new List<GameObject>();
    public List<GameObject> gameTowers = new List<GameObject>();

    private int K1, K2, _j;
    private int numList = 1; */

    public List<GameObject> GameUnits = new List<GameObject>();
    public List<Wave> Waves = new List<Wave>();
    public List<GameObject> Areas = new List<GameObject>();

    private float timeWave = 10.0f;
    private float timeUnit = 1.0f;
    private int key = 0;
    private bool created = true;
    private GameObject _loseUI;

    private GameHUD _gameHUD;

    void Start()
    {
        _gameHUD = transform.GetComponent<GameHUD>();
        CoutWave = Waves.Count;
        CurWave = 0;
        _loseUI = GameObject.FindObjectOfType<SearchLose>().gameObject;
        _loseUI.SetActive(false);
    }

    void Update()
    {
        if (timeWave <= 0.0f && created)
        {
            if (CurWave <= CoutWave - 1)
            {
                if (timeUnit <= 0.0f)
                {
                    if (key <= Waves[CurWave].Units.Count - 1)
                    {
                        Debug.Log("Spawn Unit !");
                        GameUnits.Add((GameObject)Instantiate(Waves[CurWave].Units[key], Areas[0].transform.position, Quaternion.identity));
                        key++;
                        timeUnit = 1.0f;
                    } else
                    {
                        CurWave++;
                        key = 0;
                        timeWave = 10.0f;
                        timeUnit = 1.0f;
                    }
                } else
                {
                    timeUnit -= Time.deltaTime;
                }
            } else
            {
                created = false;
            }
        } else
        {
            timeWave -= Time.deltaTime;
        }

        if (LosesUnits > 10)  {
            _loseUI.SetActive(true);
        }
    }

    


    /* public void OnShop()
    {
        _j = 0;
        if(numList * buttonTowers.Count > shopTowers.Count)
        {
            K2 = shopTowers.Count;
            K1 = (numList - 1) * buttonTowers.Count;
        }else
        {
            K2 = numList * buttonTowers.Count;
            K1 = K2 - buttonTowers.Count; 
        }
        foreach(GameObject obj in buttonTowers)
        {
            obj.SetActive(false);
        }

        for(int i = K1; i < K2; i++)
        {
            _gameHUD.textCost[_j].text = "" + shopTowers[i].GetComponent<InfoTower>().Value.Cost;
            buttonTowers[_j].SetActive(true);
            _j++;
        }
    } */
}

