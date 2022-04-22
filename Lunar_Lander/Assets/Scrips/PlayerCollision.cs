using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody RG;
    [SerializeField] float maxVelocity = 4;
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



      //  ShipExploited(collision.contacts[0].point);
    }


    void ShipExploited(Vector3 explosionPoint)
    {
     //   RG.AddExplosionForce(30f, explosionPoint, 30f,1f,ForceMode.Impulse);
    }
}
