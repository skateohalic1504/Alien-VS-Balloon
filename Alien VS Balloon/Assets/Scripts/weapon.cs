using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            //shooting logic
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
