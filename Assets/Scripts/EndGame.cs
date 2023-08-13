using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static EndGame singleton;

    [SerializeField]
    private GameObject gameUI, loseUI, winUI, player, winCamera;

    private PlayerControls controls;
    private PlayerControls.MenuActions menuActions;

    [SerializeField]
    private bool win, lose = false;

    private void Awake()
    {
        singleton = this;       
    }

    private void Start()
    {
        PlayerInput player = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInput>();
        controls = player.controls;

        menuActions = controls.Menu;

        menuActions.ExitorRestart.performed += ctx => OnPressEnter();
        menuActions.CloseGame.performed += ctx => OnExitGame();
    }

    private void OnExitGame()
    {
        Application.Quit();
    }

    private void OnPressEnter()
    {
        if (win)
        {
            SceneManager.LoadScene(0);
        }
        if (lose)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Win()
    {
        gameUI.SetActive(false);
        player.SetActive(false);
        winCamera.SetActive(true);
        winUI.SetActive(true);
        win = true;
    }

    public void Lose()
    {
        gameUI.SetActive(false);
        player.SetActive(false);
        winCamera.SetActive(true);
        loseUI.SetActive(true);
        lose = true;
    }
}
