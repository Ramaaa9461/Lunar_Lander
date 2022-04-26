using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody RG;
    [SerializeField] float maxVelocity;
    [SerializeField] GameObject explotionPrefab;
    GameObject explotion;
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas loseCanvas;

    void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (RG.velocity.magnitude > maxVelocity)
        {
            Debug.Log("No explota");
            if (collision.transform.gameObject.layer == 6)
            {
                canvas.gameObject.SetActive(true);
                Destroy(RG);
            }
        }
        else
        {
            ShipExploited(collision.contacts[0].point);
            Debug.Log("explota");
        }
    }

    static bool firstCollision = true;

    void ShipExploited(Vector3 explosionPoint)
    {
        if (firstCollision)
        {

            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                gameObject.transform.GetChild(i).gameObject.AddComponent<Rigidbody>();
            }

            RG.AddExplosionForce(3f, explosionPoint, 2f, 1f, ForceMode.Impulse);

            explotion =  Instantiate(explotionPrefab, explosionPoint, Quaternion.identity);

            Destroy(explotion, 2f);

            Destroy(gameObject, 5f);

            firstCollision = false;

            loseCanvas.gameObject.SetActive(true);
        }
    }
}
