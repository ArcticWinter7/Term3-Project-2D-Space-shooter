using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject bulletprefab;
    public float firedelay = 2.00f;
    public float cooldowntimer = 0f;
    
    void FixedUpdate()
    {
        if (cooldowntimer <= 0f)
        {
            Instantiate(bulletprefab, transform.position, transform.rotation);
            cooldowntimer = firedelay;
        }

        cooldowntimer -= 0.10f;

    }
}