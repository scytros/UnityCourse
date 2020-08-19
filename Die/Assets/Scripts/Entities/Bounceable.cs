using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceable : MonoBehaviour
{
    [SerializeField] private int bouncesLeft;
    public int BouncesLeft { get { return bouncesLeft; } }

    public void ReduceBounce()
    {
        bouncesLeft--;
    }
}