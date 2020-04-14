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
    GameObject PlayAgainButton;

    public Button[] buttons = new Button[9];

    bool isGameRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.FindObjectsOfType<Button>().OrderBy(x => x.name).ToArray();
        PlayAgainButton = GameObject.Find("Button");
        PlayAgainButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {
            if (isPlayerPlaying == false)
            {
                timeCount += Time.deltaTime;

                if (timeCount > 2f)
                {
                    randNum = Random.Range(0, 8);

                    if (buttons[randNum].GetComponent<ButtonScript>().hasBeenPlayed == false)
                    {
                        timeCount = 0f;
                        buttons[randNum].GetComponent<ButtonScript>().OnMachineClick();
                        isPlayerPlaying = true;
                    }
                }
            }
        }
    }

    public void PlayerWin()
    {
        GameLogic.FindObjectOfType<WinLose>().PlayerWin();
        PlayAgainButton.SetActive(true);
        isGameRunning = false;
        isPlayerPlaying = false;
    }

    public void PlayerLooses()
    {
        GameLogic.FindObjectOfType<WinLose>().PlayeLose();
        PlayAgainButton.SetActive(true);
        isGameRunning = false;
        isPlayerPlaying = false;
    }

    public void GameTie()
    {
        GameLogic.FindObjectOfType<WinLose>().PlayeLose();
        PlayAgainButton.SetActive(true);
        isGameRunning = false;
        isPlayerPlaying = false;
    }
}
