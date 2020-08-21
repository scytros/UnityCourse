using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLookAt2D : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void Awake()
    {
        //find target
        target = FindObjectOfType<Player>().gameObject;
    }

    private void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle -90, Vector3.forward);
    }
}