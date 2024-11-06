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
        GameObject alvo = collision.gameObject;
        Destroy(gameObject);

    }
}
