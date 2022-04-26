using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 direction = Vector3.zero;
    Vector3 rotation = Vector3.zero;
    Rigidbody RG;
    [SerializeField] float upForce;
    [SerializeField] FireEffects FireEffects;

    float rotationVelocity = 5f;
    private void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Controls();
    }

    void Controls()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            direction.y += upForce;
            FireEffects.UpPlay();
        }
        else
        {
            FireEffects.UpStop();
        }

        RG.AddForce(direction , ForceMode.Acceleration);
        transform.Rotate(rotation);

        direction = Vector3.zero;
        rotation = Vector3.zero;
    }
}
