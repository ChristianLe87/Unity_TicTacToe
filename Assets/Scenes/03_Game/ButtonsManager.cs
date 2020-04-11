using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    public Sprite O_image;
    public Sprite X_image;
    public Sprite Null_image;

    Button button0;
    Button button1;
    Button button2;

    Button button3;
    Button button4;
    Button button5;

    Button button6;
    Button button7;
    Button button8;



    // Start is called before the first frame update
    void Start()
    {
        {
            button0 = GameObject.Find("Boton_0").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_1").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_2").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;
        }

        {
            button0 = GameObject.Find("Boton_3").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_4").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_5").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;
        }

        {
            button0 = GameObject.Find("Boton_6").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_7").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;

            button0 = GameObject.Find("Boton_8").GetComponent<Button>();
            button0.GetComponent<Image>().sprite = Null_image;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
