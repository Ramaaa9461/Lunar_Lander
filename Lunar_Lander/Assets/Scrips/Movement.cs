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
    void Update()
    {
        Controls();
    }

    void Controls()
    {
       direction.x = Input.GetAxis("Horizontal");
       direction.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction.y += upForce;
        }

        RG.AddForce(direction * Time.deltaTime, ForceMode.Impulse);
        RG.AddForce(Vector3.down);
    }
}
