using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody RG;
    [SerializeField] float maxVelocity;
    void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (RG.velocity.magnitude > maxVelocity)
        {
            Debug.Log("No explota" );
        }
        else
        {
            ShipExploited(collision.contacts[0].point);
            Debug.Log("explota" );

        }


    }


    void ShipExploited(Vector3 explosionPoint)
    {
        RG.AddExplosionForce(3f, explosionPoint , 1f,1f,ForceMode.Impulse);
    }
}
