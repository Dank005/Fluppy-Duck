using UnityEngine;

public class ÑreationBackground : MonoBehaviour
{
    public GameObject currentBG, nextBG;
    private GameObject newBG;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if ((currentBG.transform.position.x <= -1f && newBG == null) || (newBG != null && newBG.transform.position.x <= -1f))
                CreateNewBg();
        }
    }

    private void CreateNewBg()
    {
        if (currentBG.transform.position.x < -10f)
        {
            Destroy(currentBG);
            currentBG = newBG;
        }

        newBG = Instantiate(nextBG, new Vector2(11.7f, -1.3f), Quaternion.identity) as GameObject;
    }
}
