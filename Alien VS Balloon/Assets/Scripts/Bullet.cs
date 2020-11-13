using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    public int damage = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right *-1 * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        redBalloon redBalloon = hitInfo.GetComponent<redBalloon>();
        orangeBalloon orangeBalloon = hitInfo.GetComponent<orangeBalloon>();
        greenBalloon greenBalloon = hitInfo.GetComponent<greenBalloon>();
        yellowBalloon yellowBalloon = hitInfo.GetComponent<yellowBalloon>();
        blueBalloons blueBalloons = hitInfo.GetComponent<blueBalloons>();

        if (redBalloon != null)
        {
            redBalloon.TakeDamage(damage);
        }

        if (orangeBalloon != null)
        {
            orangeBalloon.TakeDamage(damage);
        }

        if (greenBalloon != null)
        {
            greenBalloon.TakeDamage(damage);
        }

        if (yellowBalloon != null)
        {
            yellowBalloon.TakeDamage(damage);
        }

        if (blueBalloons != null)
        {
            blueBalloons.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
