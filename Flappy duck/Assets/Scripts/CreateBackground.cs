using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject now_bg, next_bg;
    private GameObject new_bg;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if ((now_bg.transform.position.x <= -1f && new_bg == null) || (new_bg != null && new_bg.transform.position.x <= -1f))
                CreateNewBg();
        }
    }

    private void CreateNewBg()
    {
        if (now_bg.transform.position.x < -10f)
        {
            Destroy(now_bg);
            now_bg = new_bg;
        }

        new_bg = Instantiate(next_bg, new Vector2(11.7f, -1.3f), Quaternion.identity) as GameObject;
    }
}
