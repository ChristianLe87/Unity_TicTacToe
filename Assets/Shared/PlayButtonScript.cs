using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponentInChildren<Text>().text = "Play again!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void Enable()
    {
        this.gameObject.SetActive(true);
    }
}
