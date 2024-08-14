using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float GameEndDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        //Debug.Log("LEVEL WON");
        completeLevelUI.SetActive(true);
    }

    // Start is called before the first frame update
    public void EndGame()
    {

        if(gameHasEnded == false)
        {
            Debug.Log("End Game");
            gameHasEnded = true;

            // Restart
            Invoke("Restart", GameEndDelay);

        }
        
    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
