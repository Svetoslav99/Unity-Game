
using UnityEngine;
using UnityEngine.UI; // to be able to update the score into the game from the text UI in Unity

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 96).ToString("0"); // to convert float into string. "0" is to specify only int, we don`t need floating point percision in the score.
    }
}
