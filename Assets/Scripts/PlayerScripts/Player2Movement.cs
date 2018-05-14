using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector2(0f, 0.1f));
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector2(-0.1f, 0f));
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector2(0f, -0.1f));
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector2(0.1f, 0f));
    }
}
