using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Playables;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("Shoot", 0, 2);
    }
    void Update()
    {

    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
