using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnife : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);

            if (transform.position.x <= -6.5f)
                Destroy(gameObject);
        }
    }
}
