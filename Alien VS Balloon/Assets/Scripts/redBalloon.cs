using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class redBalloon : MonoBehaviour
{
    float speed = 5;
    public int health = 100;

    public int score;

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

    public void Die()
    {
        //codigo comentado crea efecto de muerte
        //Instantiate(deathEffect, transform.position, Quaternion.identity);

        Debug.Log("hello");
        Destroy(gameObject);
    }
}
