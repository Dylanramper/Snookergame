using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public int playeronescore;
    public int playertwoscore;
    public bool playeroneturn;
    public Text turntext;


     void Start()
    {
        playeroneturn = true;
    }

    // Update is called once per frame
    void Update () {
        if (playeroneturn)
        {
            turntext.text = "Player1 Turn!";
        }
        else
        {
            turntext.text = "Player2 Turn!";
        }
    if(playeronescore  >= 8)
        {
            turntext.text = "Player1 Wins!";
        }
    if(playertwoscore >= 8)
        {
            turntext.text = "Player2 Wins!";
        }
		
	}
    public void AddScorePlayerOne(int addition)
    {
        playeronescore += addition;
    }
    public void AddScorePlayerTwo(int addition)
    {
        playertwoscore += addition;
    }
}
