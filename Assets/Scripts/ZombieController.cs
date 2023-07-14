using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] float attackRange = 5.0f;
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;
    [SerializeField] Transform player;

    [SerializeField] Vector3 target;
    [SerializeField] State currentState;

    private enum State
    {
        Patrolling,
        Attacking
    }

    void Start()
    {
        currentState = State.Patrolling;
        target = pointA.position;
    }

    void Update()
    {
        switch (currentState)
        {
            case State.Patrolling:
                Patrol();
                // Check for transition to attacking state
                if (Vector3.Distance(transform.position, player.position) < attackRange)
                {
                    currentState = State.Attacking;
                }
                break;

            case State.Attacking:
                Attack();
                // Check for transition to patrolling state
                if (Vector3.Distance(transform.position, player.position) > attackRange)
                {
                    currentState = State.Patrolling;
                    target = pointA.position; // Return to first patrol point when player gets out of range
                }
                break;
        }
    }

    void Patrol()
    {
        // Patrol between pointA and pointB
        if (Vector3.Distance(transform.position, pointA.position) < 0.1f)
        {
            target = pointB.position;
        }
        else if (Vector3.Distance(transform.position, pointB.position) < 0.1f)
        {
            target = pointA.position;
        }

        MoveTowardsTarget();
    }

    void Attack()
    {
        // Move towards the player
        target = player.position;
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        Vector3 direction = (target - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
