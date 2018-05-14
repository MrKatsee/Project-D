using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0f, 0.1f));
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-0.1f, 0f));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector2(0f, -0.1f));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(0.1f, 0f));
    }
}
