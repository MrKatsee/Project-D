using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollison : MonoBehaviour {
  
    CreateBullet myCreatBullet;
	// Use this for initialization
	void Start () {
        myCreatBullet = GetComponent<CreateBullet>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        int temp=0;
        if(c.tag == "Bullet")
        {
            temp = c.gameObject.GetComponent<ShootBullet2>().isPlayer;
        }
        if (myCreatBullet.player != temp)
        {
            Destroy(c.gameObject);
            gameObject.GetComponent<Health>().HealthDecrease();
        }
    }
    
}
