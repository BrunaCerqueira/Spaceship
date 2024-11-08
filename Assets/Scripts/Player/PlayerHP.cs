using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public static int HP = 3;
    public TMP_Text life;
    // Start is called before the first frame update
    void Start()
    {
        life.text = "Health: " + HP.ToString();  // sets HP on the UI
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            FullHealth();
            SceneManager.LoadScene("SceneDerrota");
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Bullet")) // if player collides with enemy or bullets HP lowers
        {
            HP--;
            life.text = "Health: " + HP.ToString();
        }
        Debug.Log("Encostei em alguma coisa" + collision.gameObject.tag);
    }

    public void FullHealth()
    {
        HP += 3;
    }
}
