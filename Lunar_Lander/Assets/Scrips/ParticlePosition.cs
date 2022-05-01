using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePosition : MonoBehaviour
{
    [SerializeField] Transform ship;

    private void Update()
    {
        transform.position = ship.position;
    }
}
