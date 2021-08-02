using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    

    Rigidbody2D rigid2d;
    public float speed = 8f;
    public float rotspeed = 180f;
    public float shipboundary = 0.2f;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //getting rigidbody and declaring things
        rigid2d = GetComponent<Rigidbody2D>();
        Quaternion rot = transform.rotation;
        Vector3 pos = transform.position;


        //rotation
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);

        //movement (in the right direction)
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        pos += rot * velocity;






        //map boundaries

        float scRatio = Screen.width*1.0f / Screen.height;
        float widthOrtho = Camera.main.orthographicSize * scRatio;

        if (pos.y > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize;
        }
        if (pos.y < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize;
        }


        if (pos.x > widthOrtho)
        {
            pos.x = widthOrtho;
        }
        if (pos.x < -widthOrtho)
        {
            pos.x = -widthOrtho;
        }


        //Debug.Log("Spaceshtip pos: " + (float)pos.x);
        //Debug.Log("camera pos: " + (float)-Camera.main.orthographicSize);



        //applying the movement and rotation
        rigid2d.transform.position = pos;
        rigid2d.transform.rotation = rot;
    }

    void playerdeath()
    {

    }

}
