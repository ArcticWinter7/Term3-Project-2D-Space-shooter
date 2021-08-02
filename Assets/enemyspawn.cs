using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float enemyrespawn = 100f;
    public GameObject enemyprefab;
    void FixedUpdate()
    {
        //GameObject enemyprefab = GameObject.FindWithTag("enemy");

        if (enemyrespawn <= 0f)
        {
            int sideofscreenspawn = Random.Range(1,4);//1=top, 4 = left

            float scRatio = Screen.width / Screen.height;
            float widthOrtho = Camera.main.orthographicSize * scRatio;

            //switch (sideofscreenspawn)
            //{
            //    case 1:
            //        float randx = Random.Range(0, widthOrtho);
            //        float randy = Random.Range(0, -widthOrtho);
            //        break;
            //    case 2:

            //        break;
            //    case 3:

            //        break;
            //    case 4:

            //        break;
            //}


            float randx = Random.Range(0, widthOrtho);
            float randy = Random.Range(0, -widthOrtho);

            Vector3 enemyspawnposition = new Vector3(randx, randy, 0);

            Instantiate(enemyprefab, enemyspawnposition, transform.rotation);

            enemyrespawn = 100f;
        }
        enemyrespawn--;

    }
}
