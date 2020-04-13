using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // player Win
        if (
            button1.GetComponent<ButtonScript>().buttonVal == 'X' &&
            button2.GetComponent<ButtonScript>().buttonVal == 'X' &&
            button3.GetComponent<ButtonScript>().buttonVal == 'X'
            )
        {
            this.GetComponent<Image>().enabled = true;
        }
        // player loses
        else if (
            button1.GetComponent<ButtonScript>().buttonVal == 'O' &&
            button2.GetComponent<ButtonScript>().buttonVal == 'O' &&
            button3.GetComponent<ButtonScript>().buttonVal == 'O'
            )
        {
            this.GetComponent<Image>().enabled = true;
        }
    }
}
