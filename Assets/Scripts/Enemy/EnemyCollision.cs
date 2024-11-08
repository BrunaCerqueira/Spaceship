using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour
{
    public GameObject powerup;
    public GameObject powerup2;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Invoke("CriaItem", 0f); // Drop item
            Destroy(gameObject);// destroy bullet
            Destroy(collision.gameObject); // destroy enemy
        }


    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CriaItem() // Dictates rate for drops GameObjects
    {
        int random = Random.Range(0, 6);
        if (random < 2)
        {
            Instantiate(powerup, transform.localPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(powerup2, transform.localPosition, Quaternion.identity);
        }
    }
}
