using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
     
    public GameObject followTarget; //tacke objekt to follow
    private Vector3 targetPos;      //tack objects position
    public float moveSpeed;         //camra move speed OBS never now faster then the object 

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //finds target position
        targetPos = new Vector3(followTarget.transform.position.x, 
            followTarget.transform.position.y, transform.position.z);
        
        //moves to target pos
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
