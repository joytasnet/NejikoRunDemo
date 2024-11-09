using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleController : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    void Start(){
        highScoreText.text=$"High Score : {PlayerPrefs.GetInt("HighScore")}m";
    }
    public void OnStartButtonClicked(){
        SceneManager.LoadScene("Main");
    }
}
