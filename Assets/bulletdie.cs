using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float timer = 4f;
    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
