using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI선언

public class Health : MonoBehaviour {

    public int HP = 3;
    public GameObject[] P1Hp = new GameObject[3];
    public GameObject[] P2Hp = new GameObject[3];
    int HP_temp;

    // Use this for initialization
    void Start () {
        P1Hp[0] = GameObject.Find("P1_HP1");
        P1Hp[1] = GameObject.Find("P1_HP2");
        P1Hp[2] = GameObject.Find("P1_HP3");
        P2Hp[0] = GameObject.Find("P2_HP1");
        P2Hp[1] = GameObject.Find("P2_HP2");
        P2Hp[2] = GameObject.Find("P2_HP3");
    }
	
	// Update is called once per frame
	void Update () {
        if (HP != HP_temp)
        {
            AltHP();
            HP_temp = HP;
        }

	}

    public void HealthDecrease()
    {
        HP -= 1;
        Debug.Log(HP);
    }

    void AltHP()
    {
        if (gameObject.GetComponent<CreateBullet>().player == 1)
        {
            if (HP == HP_temp + 1)
            {
                if (HP == 1)
                    P1Hp[0].SetActive(true);
                if (HP == 2)
                    P1Hp[1].SetActive(true);
                if (HP == 3)
                    P1Hp[2].SetActive(true);
            }
            if (HP == HP_temp - 1)
            {
                if (HP == 0)
                    P1Hp[0].SetActive(false);
                if (HP == 1)
                    P1Hp[1].SetActive(false);
                if (HP == 2)
                    P1Hp[2].SetActive(false);
            }
        }
        if (gameObject.GetComponent<CreateBullet>().player == 2)
        {
            if (HP == HP_temp + 1)
            {
                if (HP == 1)
                    P2Hp[0].SetActive(true);
                if (HP == 2)
                    P2Hp[1].SetActive(true);
                if (HP == 3)
                    P2Hp[2].SetActive(true);
            }
            if (HP == HP_temp - 1)
            {
                if (HP == 0)
                    P2Hp[0].SetActive(false);
                if (HP == 1)
                    P2Hp[1].SetActive(false);
                if (HP == 2)
                    P2Hp[2].SetActive(false);
            }
        }
    }

}
 