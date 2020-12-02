using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour { 
    private float time;
    public float holdTime = 2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            time += Time.deltaTime;
            if (time >= holdTime) {
                time = 0;
                RestartGame();
            }
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
