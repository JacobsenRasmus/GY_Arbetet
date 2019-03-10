using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthbar;
    public Text HPText;
    public PlayerHealthManager playerHealth;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = playerHealth.PlayerMaxHealth;
        healthbar.value = playerHealth.PlayerCurrentHealth;
        HPText.text = "HP: " + playerHealth.PlayerCurrentHealth; 
    }
}
