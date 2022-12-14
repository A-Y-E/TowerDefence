using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    public RawImage DiamondsIcon;
    public Text DiamondsText;
    public RawImage LosesUnits;
    public Text LosesText;



    // Переменные для работы с магазином
    public List<Text> textCost = new List<Text>(); 

    private GameMode gameMode;

    void Start()
    {
        gameMode = transform.GetComponent<GameMode>();
    } 
    void LateUpdate()
    {
        DiamondsText.text = "" + gameMode.Diamonds;
        LosesText.text = "" + gameMode.LosesUnits;
    }
}
