using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowBalloon : MonoBehaviour
{
    float speed = 5;
    public int health = 100;

    // Update is called once per frame
    void Update()
    {
        Vector3 subir = Vector3.up * speed;

        float timeSinceLastFrame = Time.deltaTime;
        Vector3 translation = subir * timeSinceLastFrame;

        transform.Translate(translation);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //codigo comentado crea efecto de muerte
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
