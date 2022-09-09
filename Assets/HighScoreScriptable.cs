using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScoreScriptableObject", menuName = "ScriptableObjects/Persistant-always")]
public class HighScoreScriptable : ScriptableObject
{
    public int highScore = 0;
    public string highScorePlayer = "None";
    public string playerName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
