using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.name == "WarHog_0")
        {
            //GameObject thePlayer = GameObject.Find("PlayerController");
            //PlayerController playercontroller = thePlayer.GetComponent<PlayerController>();
            ////OmSpelrenAnfaller
            //if (playercontroller.attacking == true)
            //{
            //    other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive); ;
            //}

            //if (playercontroller.attacking == false)
            //{
            //    other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            //}
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);





            this.gameObject.SetActive(false);

            //other.gameObject.SetActive(false);
            //reloading = true;

        }
    }
}
