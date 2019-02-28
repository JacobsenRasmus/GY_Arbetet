using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {

    public float moveSpeed;
    private bool facingLeft;

	// Use this for initialization
	void Start () {
        facingLeft = false;
	}
	
	// Update is called once per frame
	void Update () {

        // Move player right left
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f,0f));
        // Move player upp down
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));

        if (Input.GetAxisRaw("Horizontal") > 0.5f && !facingLeft || Input.GetAxisRaw("Horizontal") < -0.5f && facingLeft)
        {
            facingLeft = !facingLeft;
        }
    }
}
