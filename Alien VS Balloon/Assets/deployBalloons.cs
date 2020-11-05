using System.Collections;
using UnityEngine;

public class deployBalloons : MonoBehaviour
{

    public GameObject balloonPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(balloonWave());
    }

    private void spawnBalloon()
    {
        GameObject b = Instantiate(balloonPrefab) as GameObject;
        b.transform.position = new Vector2(screenBounds.y * -1, Random.Range(-screenBounds.x, screenBounds.x));

    }

    IEnumerator balloonWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBalloon();
        }
    }
}
