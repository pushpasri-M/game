using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameover;
    

    [ContextMenu("increase score")]
    public void addscore(int scoretoadd)
    {
        playerscore = playerscore + scoretoadd;
        scoreText.text = playerscore.ToString();

    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void gameOver()
    {
        gameover.SetActive(true);
    }
}
