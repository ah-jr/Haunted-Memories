using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pausePane;
    public bool isPaused = false;
    private float time = 0f;
    public float holdTime = 2f;


    // Start is called before the first frame update
    void Start() {
        pausePane.SetActive(isPaused);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!pausePane.activeInHierarchy) {
                PauseGame();
            }
            else {
                ContinueGame();
            }
        }
        if (Input.GetKey(KeyCode.R)) {
            if (pausePane.activeInHierarchy) {
                RestartGame();
            }
            else {
                time += Time.deltaTime;
                if (time >= holdTime) {
                    time = 0;
                    RestartGame();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            if (pausePane.activeInHierarchy) {
                MainMenu();
            }
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            if (pausePane.activeInHierarchy) {
                Credits();
            }
        }
    }

    public void PauseGame() {
        Time.timeScale = 0;
        isPaused = true;
        pausePane.SetActive(isPaused);
    }

    public void ContinueGame() {
        Time.timeScale = 1;
        isPaused = false;
        pausePane.SetActive(isPaused);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ContinueGame();
    }

    public void MainMenu() {
        Debug.Log("Menu ainda não implementado.");
        ContinueGame();
    }

    public void Credits() {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
        ContinueGame();
    }
}