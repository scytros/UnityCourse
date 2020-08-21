using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private Entity host;
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private GameObject projectilePosition;

    [SerializeField] private float cooldown = 10;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    private void SpawnProjectile()
    {
        GameObject projectile = GameObject.Instantiate(arrowPrefab);
        projectile.transform.position = projectilePosition.transform.position;
        projectile.transform.rotation = projectilePosition.transform.rotation;

        ProjectileHit hit = projectile.GetComponent<ProjectileHit>();
        hit.Host = host;
        hit.SetBounces(host.Stats.ProjectileBounces);
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown);
            SpawnProjectile();
        }
    }
}
