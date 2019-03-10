using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BondeController : MonoBehaviour
{

    public float moveSpeed;     // Bondens hastighet

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    public float timeToMove;
    private float timeToMoveCounter;

    private Rigidbody2D myRigidbody;    //
    private Animator anim;              // Ger oss till gång till animationerna
    private Vector3 LastMove;           // tar värdet på senaste riktning vi rörde oss
    private Vector3 moveDirection;      // vilken riktning ska han röra sig
    private bool moving;
    private bool IsMoving;              // Rörsig spelaren Ja nej



    public float waitToReload;
    private bool reloading;
    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //IsMoving = false;
        if (moving)
        {
            IsMoving = true;
            timeToMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = moveDirection;

            if(timeBetweenMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = timeBetweenMove;
            }
        }
        else
        {
            IsMoving = false;
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = timeToMove;

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed * Time.deltaTime, 
                    Random.Range(-1f, 1f) * moveSpeed * Time.deltaTime, 0f);
                LastMove = moveDirection;
            }
        }

        
        /*

        // Move player right left
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            IsMoving = true;
            LastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        // Move player upp down
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            IsMoving = true;
            LastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }
        */

        // ger animationer värde
        anim.SetFloat("MoveX", moveDirection.x);
        anim.SetFloat("MoveY", moveDirection.y);
        anim.SetBool("IsMoving", IsMoving);
        anim.SetFloat("LastMoveX", LastMove.x);
        anim.SetFloat("LastMoveY", LastMove.y);


        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if(waitToReload < 0)
            {
                SceneManager.LoadScene(0);
                    
            }
        }
    }

    //Collission
    void OnCollisionEnter2D(Collision2D other)
    {
        /*if(other.gameObject.name == "WarHog_0")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            reloading = true;

        } */
    }
}