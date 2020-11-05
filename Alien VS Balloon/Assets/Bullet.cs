using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        balloon balloon = hitInfo.GetComponent<balloon>();
        if (balloon != null)
        {
            balloon.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
