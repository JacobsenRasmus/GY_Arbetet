using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;     // spelarens hastighet
    private Animator anim;      // Ger oss till gång till animationerna
    private bool PlayerMoving;  // Rörsig spelaren Ja nej
    private Vector2 LastMove;   // tar värdet på senaste riktning vi rörde oss

    private Rigidbody2D playerRigidbody;
    //private bool facingLeft;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //    facingLeft = false;
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoving = false;

        // Move player right left
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRigidbody.velocity.y);
            PlayerMoving = true;
            LastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        // Move player upp down
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
            PlayerMoving = true;
            LastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        //make player stop when releasing button
        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            playerRigidbody.velocity = new Vector2(0f, playerRigidbody.velocity.y);
        }

        //make player stop when releasing button
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, 0f);
        }

        // ger animationer värde
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", PlayerMoving);
        anim.SetFloat("LastMoveX", LastMove.x);
        anim.SetFloat("LastMoveY", LastMove.y);

        /*/ ska vrida på spelaren
        if (Input.GetAxisRaw("Horizontal") > 0.5f && !facingLeft || Input.GetAxisRaw("Horizontal") < -0.5f && facingLeft)
        {
            facingLeft = !facingLeft;
        }*/
    }
}