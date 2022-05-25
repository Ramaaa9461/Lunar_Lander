using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody RG;
    [SerializeField] float maxVelocity;
    [SerializeField] GameObject explotionPrefab;
    GameObject explotion;
    [SerializeField] Canvas canvas;
    [SerializeField] Text finalText;

    void Awake()
    {
        RG = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude < maxVelocity)
        {
            if (collision.transform.gameObject.layer == 6)
            {
                finalText.text = "You have Won!";
                canvas.gameObject.SetActive(true);
                Destroy(RG);
            }
            Debug.Log("No exploto");
        }
        else
        {
            ShipExploited(collision.contacts[0].point);
        }
    }
    void ShipExploited(Vector3 explosionPoint)
    {
        Debug.Log("explota", gameObject);

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.AddComponent<Rigidbody>();
        }

        RG.AddExplosionForce(3f, explosionPoint, 2f, 1f, ForceMode.Impulse);

        explotion = Instantiate(explotionPrefab, explosionPoint, Quaternion.identity);

        Destroy(explotion, 2f);

        Destroy(gameObject, 5f);

        finalText.text = "You have Lost!";
        canvas.gameObject.SetActive(true);
    }

    void Update()
    {
        if (transform.position.y < -10) 
        {
            ShipExploited(transform.position);
        }
    }

}
