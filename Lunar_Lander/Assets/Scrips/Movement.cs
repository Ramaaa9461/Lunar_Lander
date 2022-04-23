using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 direction = Vector3.zero;
    Rigidbody RG;
    [SerializeField] float upForce;

    private void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        Controls();
    }

    void Controls()
    {
       direction.x = Input.GetAxis("Horizontal");
       direction.z = Input.GetAxis("Vertical");

        if (direction.x < 0) //Se instancia el fuegoo
        {

        }
        if (direction.x > 0)
        {

        }
        if (direction.y < 0)
        {

        }
        if (direction.y > 0)
        {

        }
        if (Input.GetKey(KeyCode.Space))
        {
            direction.y += upForce;
        }

        RG.AddForce(direction , ForceMode.Acceleration);
        direction.y = 0;
    }
}
