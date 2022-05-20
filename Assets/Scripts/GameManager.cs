using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject inGamePanel;
    public GameObject gameOverPanel;
    public GameObject passLevelPanel;

    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != null)
        {
            Destroy(gameObject);
        }
    }
    public enum GameStates
    {
        Start,
        InGame,
        GameOver,
        PassLevel
    }

    public GameStates currentState;

    private void Start()
    {
        currentState = GameStates.Start;
    }

    public enum GamePanel
    {
        StartPanel,
        InGamePanel,
        GameOverPanel,
        PassLevelPanel
    }

    private void Update()
    {
        switch(currentState)
        {
            case GameStates.Start: GameStart();
                break;
            case GameStates.InGame: GameInGame();
                break;
            case GameStates.GameOver: GameOver();
                break;
            case GameStates.PassLevel: GameNextLevel();
                break;
        }
    }

    void PanelController(GamePanel currentPanel)
    {
        startPanel.SetActive(false);
        inGamePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        passLevelPanel.SetActive(false);
        
        switch(currentPanel)
        {
            case GamePanel.StartPanel:
                startPanel.SetActive(true);
                break;
            case GamePanel.InGamePanel:
                inGamePanel.SetActive(true);
                break;
            case GamePanel.GameOverPanel:
                gameOverPanel.SetActive(true);
                break;
            case GamePanel.PassLevelPanel:
                passLevelPanel.SetActive(true);
                break;

        }
    }

    public void GameStart()
    {
        PanelController(GamePanel.StartPanel);
    }

    public void GameInGame()
    {
        PanelController(GamePanel.InGamePanel);
    }

    public void GameOver()
    {
        PanelController(GamePanel.GameOverPanel);
    }

    public void GameNextLevel()
    {
        PanelController(GamePanel.PassLevelPanel);
    }


}
