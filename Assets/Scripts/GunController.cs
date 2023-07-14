using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 20f;
    [SerializeField] Transform shootingPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // You can replace this with your preferred firing input
        {
            GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = shootingPoint.forward * projectileSpeed;
        }
    }
}
