using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet2 : MonoBehaviour
{
    public int isPlayer;
    public float speed;

    // Use this for initialization
    void Start()
    {
        if (isPlayer == 1)
            GetComponent<Rigidbody2D>().velocity = speed * Vector2.right;


        else if (isPlayer == 2)
            GetComponent<Rigidbody2D>().velocity = speed * Vector2.left;

        Destroy(gameObject, 5f);

        //StartCoroutine(FlyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FlyBullet()
    {
        while(true)
        {

            yield return null;
        }
    }
}
    
