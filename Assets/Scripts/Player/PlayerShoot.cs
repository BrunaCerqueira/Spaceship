using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    GameObject shooter;
    public GameObject tiro;
    public float cooldown = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        shooter = transform.Find("Shooter").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiro, shooter.transform.position, Quaternion.identity);
        }
    }
}
