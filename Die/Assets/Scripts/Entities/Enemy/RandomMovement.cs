using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float movementCooldown = 1;
    [SerializeField] private float movementForce = 50;

    private void Start()
    {
        StartCoroutine(MakeRandomMovement());
    }

    private IEnumerator MakeRandomMovement()
    {
        while (true)
        {
            yield return new WaitForSeconds(movementCooldown);

            float randomForceX = Random.Range(-movementForce, movementForce);
            float randomForceY = Random.Range(-movementForce, movementForce);

            Vector2 velocity = new Vector2(randomForceX, randomForceY);
            rb.velocity = velocity;
        }
    }
}