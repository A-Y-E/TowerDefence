using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMain : MonoBehaviour

{
    private void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(delegate { onClick(); });
    }
    public void onClick()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}