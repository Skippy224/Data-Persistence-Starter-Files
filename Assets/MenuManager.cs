using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] HighScoreScriptable highScoreScript;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] TextMeshProUGUI input;
    // Start is called before the first frame update
    void Start()
    {
        DisplayHighScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    void DisplayHighScore()
    {
        highScoreText.text = $"High Score: {highScoreScript.highScorePlayer}: {highScoreScript.highScore}";
    }

    public void NewPlayer()
    {
        highScoreScript.playerName = input.text;
    }
}
