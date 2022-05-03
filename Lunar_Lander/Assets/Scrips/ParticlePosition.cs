using UnityEngine;

public class ParticlePosition : MonoBehaviour
{
    [SerializeField] Transform ship;

    private void Update()
    {
        if(ship) transform.position = ship.position;
    }
}
