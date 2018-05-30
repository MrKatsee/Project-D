using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBarIncrease : MonoBehaviour {

    public Image skillBarGuage;
    public int isBar;
    GameObject temp;
    public int isPlayer;
    Health playerHealth;

    // Use this for initialization
    void Start() {
        skillBarGuage = GetComponent<Image>();

        if (isPlayer == 1) {
            playerHealth = GameObject.Find("Player1").GetComponent<Health>();
        }

        if (isPlayer == 2)
        {
            playerHealth = GameObject.Find("Player2").GetComponent<Health>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isBar == 1)
        {
            skillBarGuage.fillAmount = playerHealth.skillBar;
        }
        if (isBar == 0)
        {
            skillBarGuage.fillAmount = playerHealth.guageStack;
        }
    }
}
