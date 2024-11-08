using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilMove : MonoBehaviour
{
    public float bulletspeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * bulletspeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // enemy destroy
            GameManager.instance.GainPoints(1);
            Destroy(gameObject); // bullet destroy 
        }



    }
}
