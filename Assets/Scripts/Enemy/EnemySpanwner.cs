using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanwner : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyGenerator", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = (new Vector3(transform.localPosition.x, Random.Range(-4, 4), transform.localPosition.z));
    }

    public void EnemyGenerator()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
