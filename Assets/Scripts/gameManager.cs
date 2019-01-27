using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameIsOver = false;
    public void gameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GAMEOVER!");
            gameOverScreen();
        }
       
    }

    void gameOverScreen()
    {
        SceneManager.LoadScene(2);
    }
}
