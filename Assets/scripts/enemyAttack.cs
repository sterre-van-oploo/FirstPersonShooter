using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    private enemyMovement enemymovement;
    private Transform player;
    public float attackRange = 20f;

    public Material attackMaterial;
    public Material defaultMaterial;
    private Renderer rend;

    private bool foundPlayer = false    ;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemymovement = GetComponent<enemyMovement>();
        rend = GetComponent<Renderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= attackRange) 
        {
            rend.sharedMaterial = attackMaterial;
            enemymovement.badGuy.SetDestination(player.position);
            foundPlayer = true ;
        }
        else if (foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            enemymovement.newLocation();
            foundPlayer = false ;

        }
    }
}
