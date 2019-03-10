using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
     
    public GameObject followTarget; //tacke objekt to follow
    private Vector3 targetPos;      //tack objects position
    public float moveSpeed;         //camra move speed OBS never now faster then the object 


    public BoxCollider2D boundBox;
    private Vector3 minBounds;
    private Vector3 maxBounds;

    private Camera theCamera;

    private float halfHeight;
    private float halfWidth;
    // Use this for initialization
    void Start () {
        minBounds = boundBox.bounds.min;
        maxBounds = boundBox.bounds.max;

        theCamera = GetComponent<Camera>();
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }
	
	// Update is called once per frame
	void Update () {
        //finds target position
        targetPos = new Vector3(followTarget.transform.position.x, 
            followTarget.transform.position.y, transform.position.z);
        
        //moves to target pos
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);


        float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
        float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

    }
}
