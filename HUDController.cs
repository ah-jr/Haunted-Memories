using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {
    public Text texto;
    private int valor;

    private Transform playerTransform;
    // Start is called before the first frame update
    void Start() {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (texto.text.Contains("Jump Power:")) {
            texto.text = "Jump Power: " + Mathf.RoundToInt(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>()._jumpHeight);
        }
        else if (texto.text.Contains("Height:")) {
            int altura = Mathf.RoundToInt(playerTransform.position.y) + 18;
            texto.text = "Height: " + altura;
        }
        
    }
}
