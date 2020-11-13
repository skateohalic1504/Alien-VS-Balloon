using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider : MonoBehaviour
{
    public float restartDelay = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit detected");
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
        FindObjectOfType<gameManager>().EndGame();
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
