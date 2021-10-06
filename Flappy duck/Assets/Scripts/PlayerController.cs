using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;

    private Vector3 targetPos;

    private void Update()
    {
        if (StartGame.isStart)
        {
#if UNITY_ANDROID
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    targetPos = Camera.main.ScreenToWorldPoint(touch.position);
                }
            }
#endif

#if UNITY_EDITOR
            if (Input.GetMouseButton(0))
            {
                targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
#endif
            float step = speed * Time.deltaTime;

            if (targetPos.y < -3f)
                targetPos.y = -3f;

            if (targetPos.y > 0f)
                targetPos.y = 0f;

            player.transform.position = Vector3.MoveTowards(player.transform.position,
                new Vector3(player.transform.position.x, targetPos.y, player.transform.position.z), step);
        }
    }
}
