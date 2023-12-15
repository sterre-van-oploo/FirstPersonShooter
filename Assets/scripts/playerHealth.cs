using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currenthealth;

    public healthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    
 
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(10);
        //}

        if (currenthealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthBar.setHealth(currenthealth);

    }

    //void PlusHealth(int health)
    //{ 
    //    currenthealth += health;
    //    healthBar.setHealth(currenthealth);
    //}


    //void OnCollisionHealth(Collision collision)
    //{
    //    if (collision.gameObject.tag == "table")
    //    {
    //        PlusHealth(10);
    //    }
    //}


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "NPC")
        {

            TakeDamage(15);

        }
    }

}
