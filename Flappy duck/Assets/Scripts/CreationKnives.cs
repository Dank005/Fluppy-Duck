using System.Collections;
using UnityEngine;

public class CreationKnives : MonoBehaviour
{
    public GameObject knife;
    public float waitTime = 1f;

    private bool isSpawn;
    private Coroutine spawn;

    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(SpawnKnives());
            isSpawn = true;
        }
    }

    IEnumerator SpawnKnives()
    {
        while(true)
        {
            if (StartGame.isStart)
                Instantiate(knife, new Vector2(6.17f, Random.Range(-3.27f, 0)), Quaternion.Euler(new Vector3(0, 0, -45)));

            else
                StopCoroutine(spawn);

            yield return new WaitForSeconds(waitTime);
        }
    }
}
