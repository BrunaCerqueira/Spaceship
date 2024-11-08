using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public int HP = 3;
    public TMP_Text life;
    // Start is called before the first frame update
    void Start()
    {
        life.text = "Health: " + HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bullet")
        {
            HP--;
            life.text = "Health: " + HP.ToString();
        }
    }
}
