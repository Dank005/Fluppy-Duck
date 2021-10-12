using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject title;
    public GameObject score;
    public Button playButton;

    public float titleSpeed=5f;
    public static bool isStart;

    public void StartButton()
    {
        if (isStart)
            return;

        isStart = true;
        title.GetComponent<Animator>().enabled = false;
        Destroy(title, 1.5f);
        playButton.GetComponent<Animation>().Play("PlayButton");

        score.SetActive(true);
    }

    public void ReStartButton()
    {
        SceneManager.LoadScene("Main");
    }

    private void Update()
    {
        if (isStart && title != null)
            title.transform.Translate(Vector2.up * titleSpeed * Time.deltaTime);
    }
}
