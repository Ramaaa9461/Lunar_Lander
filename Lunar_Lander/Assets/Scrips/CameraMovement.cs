using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] GameObject ship;
    [SerializeField] Vector3 offSet;
    [SerializeField] float distance = 10;
    [SerializeField] float height = 5;

    [SerializeField] private float rotationDamping;
    [SerializeField] private float heightDamping;
    void Start()
    {

    }
    void Update()
    {
        if (ship.transform.position.y < 25)
        {

            var wantedRotationAngle = ship.transform.eulerAngles.y;
            var wantedHeight = ship.transform.position.y + height;
            var currentRotationAngle = transform.eulerAngles.y;
            var currentHeight = transform.position.y;

            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

            var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            transform.position = ship.transform.position;

            transform.position -= currentRotation * Vector3.forward * distance;

            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

            transform.LookAt(ship.transform);
        }
        else
        {
            transform.position = ship.transform.position; 
            transform.rotation = Quaternion.Euler(0, ship.transform.eulerAngles.y - height, 0); 
            transform.Translate(Vector3.forward * 2 + offSet, Space.Self);
        }
    }
}
