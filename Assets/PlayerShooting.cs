using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletprefab;

    public float firedelay = 2.00f;
    public float cooldowntimer = 0f;
    public int hp = 5;

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && cooldowntimer <= 0f)
        {
            Vector3 bulletplace = new Vector3(0,0,0);
            Instantiate(bulletprefab, transform.position, transform.rotation);
            cooldowntimer = firedelay;
        }

        cooldowntimer -= 0.30f;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemybullet" || collision.gameObject.tag == "enemy")
        {
            hp--;
            if (hp <= 0)
            {
                die();
            }
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
