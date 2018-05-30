using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI선언

public class Health : MonoBehaviour {

    public int isPlayer;
    public float guageStack = 0f;
    public int HP = 3;
    public GameObject[] P1Hp = new GameObject[3];
    public GameObject[] P2Hp = new GameObject[3];
    public float skillBar = 0;
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

        if (skillBar <= 1f)
        {
            skillBar += 0.2f * Time.deltaTime;
        }

        if (isPlayer == 1)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                if (guageStack == 0f)
                {
                    if (skillBar >= 0.25f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.25f)
                {
                    if (skillBar >= 0.5f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.5f)
                {
                    if (skillBar >= 0.75f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.75f)
                {
                    if (skillBar >= 1f)
                    {
                        guageStack += 0.25f;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (guageStack == 0.25f)
                {
                    skillBar -= 0.25f;
                    guageStack = 0;
                }
                else if (guageStack == 0.5f)
                {
                    skillBar -= 0.50f;
                    guageStack = 0;
                }
                else if (guageStack == 0.75f)
                {
                    skillBar -= 0.75f;
                    guageStack = 0;
                }
                else if (guageStack == 1f)
                {
                    skillBar -= 1f;
                    guageStack = 0;
                }
            }
        }

        if (isPlayer == 2)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                if (guageStack == 0f)
                {
                    if (skillBar >= 0.25f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.25f)
                {
                    if (skillBar >= 0.5f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.5f)
                {
                    if (skillBar >= 0.75f)
                    {
                        guageStack += 0.25f;
                    }
                }
                else if (guageStack == 0.75f)
                {
                    if (skillBar >= 1f)
                    {
                        guageStack += 0.25f;
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                if (guageStack == 0.25f)
                {
                    skillBar -= 0.25f;
                    guageStack = 0;
                }
                else if (guageStack == 0.5f)
                {
                    skillBar -= 0.50f;
                    guageStack = 0;
                }
                else if (guageStack == 0.75f)
                {
                    skillBar -= 0.75f;
                    guageStack = 0;
                }
                else if (guageStack == 1f)
                {
                    skillBar -= 1f;
                    guageStack = 0;
                }
            }
        }
    }

    public void HealthDecrease()
    {
        HP -= 1;
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
 