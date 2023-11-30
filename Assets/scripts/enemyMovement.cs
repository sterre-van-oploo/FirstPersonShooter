using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    public NavMeshAgent badGuy;

    public float squireOfMovement = 20f;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;

    private float xPosition;
    private float yPosition;
    private float ZPosition;

    public float closeEnough = 2f;

    // Start is called before the first frame update
    void Start()
    {
        xMin = -squireOfMovement;
        xMax = squireOfMovement;
        zMin = -squireOfMovement;
        zMax = squireOfMovement;

        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, ZPosition)) <= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        ZPosition = Random.Range(zMin, zMax);

        badGuy.SetDestination(new Vector3(xPosition, yPosition, ZPosition));
    }
}
