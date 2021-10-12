using UnityEngine;

public class DetectionCollision : MonoBehaviour
{
    public GameObject panelLose;
    public Color deathColor;

    private SpriteRenderer sr;
    private AudioSource audioLose;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioLose = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            StartGame.isStart = false;
            Destroy(collision.transform.parent.gameObject);
            sr.color = deathColor;
            audioLose.Play();
            panelLose.SetActive(true);
        }
    }
}
