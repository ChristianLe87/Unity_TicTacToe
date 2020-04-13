using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public bool isPlayerPlaying = true;
    float timeCount = 0;
    int randNum = 0;

    public Button[] buttons = new Button[9];

    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.FindObjectsOfType<Button>().OrderBy(x => x.name).ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerPlaying == false)
        {
            timeCount += Time.deltaTime;

            if (timeCount > 2f)
            {
                randNum = Random.Range(0, 8);

                // ToDo: Fix infinit loop error when no more options avalible
                if (buttons[randNum].GetComponent<ButtonScript>().hasBeenPlayed == false)
                {
                    isPlayerPlaying = true;
                    timeCount = 0f;
                    buttons[randNum].GetComponent<ButtonScript>().OnMachineClick();
                }
            }
        }
    }
}
