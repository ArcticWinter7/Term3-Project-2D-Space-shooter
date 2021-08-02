using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagehandler : MonoBehaviour
{

    float hp = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
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
