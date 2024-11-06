using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -7)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < 9)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * (-1));
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && transform.position.y < 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && transform.position.y > -5)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

    }
}
