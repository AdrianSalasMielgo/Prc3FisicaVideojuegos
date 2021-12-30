using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public GameObject player;
    public enum gameStates { Playing, Win, GameOver };
    public gameStates gameState = gameStates.Playing;
    public GameObject gameOverCanvas;
    public GameObject winCanvas;

    private isLive live;
    private WinCondition win;
    void Start()
        
    {
        if (gm == null)
        {
            gm = gameObject.GetComponent<GameManager>();
        }
            
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        live = player.GetComponent<isLive>();
        win = player.GetComponent<WinCondition>();

        gameState = gameStates.Playing;
        // Desactivamos el Canvas gameOver, just in case.
        gameOverCanvas.SetActive(false);
    }
    void Update()
    {
        switch (gameState)
        {

            case gameStates.Playing:
                if (live.live == false)
                { 
                    gameState = gameStates.GameOver;
                }

                if(win.win == true)
                {
                    gameState = gameStates.Win;
                }

                // win condition
                break;
            case gameStates.GameOver:
                gameOverCanvas.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                // nothing
                break;
            case gameStates.Win:
                winCanvas.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                // win
                break;
        }
    }
}
