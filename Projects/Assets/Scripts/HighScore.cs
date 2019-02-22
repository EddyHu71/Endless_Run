using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text textScore;
    public Text textHighScore;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        if (Data.score > highscore)
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }

        textScore.text = "Your Score : " + Data.score;
        textHighScore.text = "High Score : " + highscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
