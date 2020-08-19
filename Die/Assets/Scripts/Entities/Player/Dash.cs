using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] private Movement movement;

    [SerializeField] private float cooldown = 10;
    [SerializeField] private float cooldownLeft = 0;
    [SerializeField] private bool canUseAbility = true;
    [SerializeField] private float dashDistance = 10f;
    [SerializeField] private float dashDuration = 0.15f;

    //private void Update()
    //{
    //    if (cooldownLeft > 0)
    //    {
    //        cooldownLeft -= (1 * Time.deltaTime);

    //    }
    //    else
    //    {
    //        cooldownLeft = 0;
    //        canUseAbility = true;
    //    }

    //    if (canUseAbility && Input.GetAxis("Dash") > 0)
    //    {
    //        cooldownLeft = cooldown;
    //        canUseAbility = false;

    //        var toPos = movement.CalculateMovementDirection();
    //        var direction = (toPos - transform.position);

    //        direction.z = 0;

    //        if (direction.magnitude >= 0.1f)
    //        {
    //            StartCoroutine(UseDash(direction.normalized));
    //        }
    //    }
    //}

    //private IEnumerator UseDash(Vector3 direction)
    //{
    //    if (dashDistance <= 0.001f)
    //        yield break;

    //    if (dashDuration <= 0.001f)
    //    {
    //        transform.position += direction * dashDistance;
    //        yield break;
    //    }

    //    float elapsedTime = 0f;
    //    var start = transform.position;
    //    var target = transform.position + dashDistance * direction;

    //    while (elapsedTime < dashDuration)
    //    {
    //        Vector3 newTarget = Vector3.Lerp(start, target, elapsedTime / dashDuration);
    //        transform.position = newTarget;

    //        yield return null;
    //        elapsedTime += Time.deltaTime;
    //    }

    //    transform.position = target;
    //}
}