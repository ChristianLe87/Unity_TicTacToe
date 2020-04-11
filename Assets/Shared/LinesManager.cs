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
        
    }

    public void ShowLine(string lineName)
    {

    }
}
