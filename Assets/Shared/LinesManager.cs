using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LinesManager : MonoBehaviour
{

    GameObject lineH1;
    GameObject lineH2;
    GameObject lineH3;

    GameObject lineV1;
    GameObject lineV2;
    GameObject lineV3;

    GameObject lineI1;
    GameObject lineI2;

    Button[] buttons = new Button[9];

    // Start is called before the first frame update
    void Start()
    {

        buttons = GameObject.FindObjectsOfType<Button>().OrderBy(x => x.name).ToArray();

        {
            lineH1 = GameObject.Find("Line_H1");
            lineH1.SetActive(false);

            lineH2 = GameObject.Find("Line_H2");
            lineH2.SetActive(false);

            lineH3 = GameObject.Find("Line_H3");
            lineH3.SetActive(false);
        }

        {
            lineV1 = GameObject.Find("Line_V1");
            lineV1.SetActive(false);

            lineV2 = GameObject.Find("Line_V2");
            lineV2.SetActive(false);

            lineV3 = GameObject.Find("Line_V3");
            lineV3.SetActive(false);
        }

        {
            lineI1 = GameObject.Find("Line_I1");
            lineI1.SetActive(false);

            lineI2 = GameObject.Find("Line_I2");
            lineI2.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Line H1
        if (isLineWin('X', 0, 1, 2))
        {
            lineH1.SetActive(true);
        }
        // Line H2
        else if (isLineWin('X', 3, 4, 5))
        {
            lineH2.SetActive(true);
        }
        // Line H3
        else if (isLineWin('X', 6, 7, 8))
        {
            lineH3.SetActive(true);
        }

        // Line V1
        else if (isLineWin('X', 0, 3, 6))
        {
            lineV1.SetActive(true);
        }
        // Line V2
        else if (isLineWin('X', 1, 4, 7))
        {
            lineV2.SetActive(true);
        }
        // Line V3
        else if (isLineWin('X', 2, 5, 8))
        {
            lineV3.SetActive(true);

        }

        // Line I1
        else if (isLineWin('X', 0, 4, 8))
        {
            lineI1.SetActive(true);
        }
        // Line I2
        else if (isLineWin('X', 2, 4, 6))
        {
            lineI2.SetActive(true);
        }


    }
    
    private bool isLineWin(char chr, int el1, int el2, int el3)
    {
        var arr = new Button[3] { buttons[el1], buttons[el2], buttons[el3] };
        var result = arr
            //.Select(x => x)
            .Where(x=>x.GetComponent<ButtonScript>().buttonVal == chr)
            .ToList();

        if (result.Count() == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public void ShowLine(string lineName)
    {

    }
}
