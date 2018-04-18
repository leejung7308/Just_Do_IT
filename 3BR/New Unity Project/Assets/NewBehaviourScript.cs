using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.05f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0.0f, 3.0f, 0.0f);
        }
    }
}
