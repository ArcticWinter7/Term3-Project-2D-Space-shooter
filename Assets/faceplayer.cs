using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceplayer : MonoBehaviour
{

    public int playerspawntime = 20;

    public GameObject player;

    public float speed = 2f;

    void Update()
    {
        GameObject player = GameObject.Find("spaceship");
        try
        {
            //if (player == null)
            //{
            //    GameObject playerobj = GameObject.Find("spaceship");
            //    player = playerobj;
            //    Debug.Log("breakpoint");

            //}
            //Vector3 direction = player.transform.position - transform.position;

            //direction.Normalize();

            //float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            //transform.rotation = Quaternion.Euler(0, 0, zAngle);

            transform.up = player.transform.position - transform.position;
        }
        catch
        {
            Debug.Log("waiting");
        }


        GameObject enemy = GameObject.FindWithTag("enemy");

        

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);
        transform.position += transform.rotation * velocity;
    }
}
