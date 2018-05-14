using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour {

    public GameObject bullet1;
    public int player;

	// Use this for initialization
	void Start () {
        StartCoroutine(ShootBullet(gameObject));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    IEnumerator ShootBullet(GameObject parent)
    {
        while (true)
        {
            if (player == 1)
            {
                GameObject obj = Instantiate(bullet1);
                obj.transform.position = parent.transform.position;
                obj.transform.position += new Vector3(1f, 0f, 0f);
                obj.gameObject.GetComponent<ShootBullet2>().isPlayer = 1;
                yield return new WaitForSeconds(1f);
            }

            else if (player == 2)
            {
                GameObject obj = Instantiate(bullet1);
                obj.transform.position = parent.transform.position;
                obj.transform.position += new Vector3(-1f, 0f, 0f);
                obj.gameObject.GetComponent<ShootBullet2>().isPlayer = 2;
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
