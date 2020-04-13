using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public Sprite win;
    public Sprite lose;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerWin()
    {
        this.GetComponent<Image>().sprite = win;
        this.GetComponent<Image>().enabled = true;
    }

    public void PlayeLose()
    {
        this.GetComponent<Image>().sprite = lose;
        this.GetComponent<Image>().enabled = true;
    }
}
