using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    public int PlayerMaxHealth;
    public int PlayerCurrentHealth;


    // Start is called before the first frame update
    void Start()
    {
        PlayerCurrentHealth = PlayerMaxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
            
        }
    }

    public void HurtPlayer (int damageToGive)
    {
        PlayerCurrentHealth -= damageToGive;
    }
    public void SetMaxHealth()
    {
        PlayerCurrentHealth = PlayerMaxHealth;
    }
}
