using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoUnit : MonoBehaviour
{
    public Unit Value = new Unit();

    private int key = 0;
    private bool move = true; 
    private GameMode gameMode;

    void Start()
    {
        gameMode = GameObject.FindGameObjectWithTag("GameMode").GetComponent<GameMode>();
    }

    void Update()
    {
        if(move)
        {
            if(key <= gameMode.Areas.Count - 1)
            {
                if (Vector3.Distance(transform.position, gameMode.Areas[key].transform.position) > 0.0f)
                {  
                    transform.position = Vector3.MoveTowards(transform.position, gameMode.Areas[key].transform.position, Value.Speed * Time.deltaTime);
                    
                }else
                {
                    key++;
                }
            }else
            {
                move = false;
            }
        }else
        {
            gameMode.LosesUnits++;
            gameMode.GameUnits.Remove(transform.gameObject);
            Destroy(transform.gameObject);
            if(gameMode.LosesUnits > 9)
            {
                Debug.Log("Лох");
            }
        }
        if(Value.Health < 0.0f)
        {
            gameMode.Diamonds += Value.Diamonds;
            gameMode.GameUnits.Remove(transform.gameObject);
            Destroy(transform.gameObject);
        }
    //}
    //private void OnDestroy() {
    //    Debug.Log("Убил");
    //}
    }
}