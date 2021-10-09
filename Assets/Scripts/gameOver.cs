using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text gameOverText;

    public void callGameOver() {
	gameOverText.text = "Game Over!";
        Debug.Log("game over"); 
    }

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
	callGameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
