using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            score++;
            scoreText.text = "Score : " + score.ToString();

            if (PlayerPrefs.GetInt("score") < score)
                PlayerPrefs.SetInt("score", score);
        }
    }
}
