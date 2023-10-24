using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private FirstPersonMovement playerHealth;
    public HealthScript _healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<FirstPersonMovement>();
        playerHealth.currentHealth = playerHealth.health;
        _healthbar.UpdateHealthbar(playerHealth.health,playerHealth.currentHealth);
    }
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            playerHealth.health -= 10;
            Debug.Log("La bala ha alcanzado al jugador, salud: "+playerHealth.health);
            Destroy(gameObject);
            /*
            if(playerHealth.health < 10){
                Destroy(playerHealth);
            }else{
                _healthbar.UpdateHealthbar(playerHealth.health,playerHealth.currentHealth);
            }
            */
        }
    }
}
