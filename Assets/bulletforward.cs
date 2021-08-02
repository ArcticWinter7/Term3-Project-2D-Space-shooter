using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletforward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 12f;
    public Rigidbody2D bulletbody;
    //public Rigidbody2D enemy;
    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 pos = bulletbody.transform.position;
        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);
        bulletbody.transform.position += transform.rotation * velocity;
    }
    //public void OnTriggerEnter2D()
    //{
    //    Destroy(gameObject);
    //}


}
