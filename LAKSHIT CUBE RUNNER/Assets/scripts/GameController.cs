 using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject TapToStart;
    public GameObject gameoverpanel;
    public GameObject score;
    public playercollison playercollison;
    public NewBehaviourScript script;
    private void Start()
    {
        gameoverpanel.SetActive(false);
        PauseGame();
        score.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
            

        }
    }
    public void GameOver()
    {
        gameoverpanel.SetActive(true);
        score.SetActive(false);
        script.backgroundSource.Play();
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        TapToStart.SetActive(true);
        playercollison.audioSource.Stop();
        playercollison.gameover.Stop();

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        TapToStart.SetActive(false);
        score.SetActive(true);
        playercollison.audioSource.Stop();
        playercollison.gameover.Stop();
        script.backgroundSource.Play();
    }

}
