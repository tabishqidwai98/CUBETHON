using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score : MonoBehaviour
{

    public Transform player;
    public TMP_Text scoreText;
    int playerPosition;

    // Update is called once per frame
    void Update()
    {
        // Update the score text
        playerPosition = (int)player.position.z;
        scoreText.text = playerPosition.ToString();
        
    }

}
