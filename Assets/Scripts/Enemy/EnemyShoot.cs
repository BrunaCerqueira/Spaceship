using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Playables;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float enemyspeed = 2;
    void Start()
    {
        InvokeRepeating("Shoot", 0, 2);
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * enemyspeed);
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
