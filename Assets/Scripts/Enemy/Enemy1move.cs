using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1move : MonoBehaviour
{
    public float enemyspeed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * enemyspeed);
    }
}
