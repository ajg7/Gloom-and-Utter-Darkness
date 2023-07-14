using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float maxLifetime = 5f;
    [SerializeField] float maxTravelDistance = 100f;

    [SerializeField] Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Destroy(gameObject, maxLifetime);
    }

    void Update()
    {
        if (Vector3.Distance(startPosition, transform.position) > maxTravelDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
