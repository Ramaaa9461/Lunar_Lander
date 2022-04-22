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

    // Update is called once per frame
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
        }
        if (Input.GetKey(KeyCode.P))
        {
           RG.velocity = new Vector3(0, -10f, 0);
        }

        RG.AddForce(direction , ForceMode.Acceleration);
        direction.y = 0;
    }
}
