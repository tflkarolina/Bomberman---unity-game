using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform[] target;


    [SerializeField] private float moveSpeed = 1f;

    Rigidbody myRigidBody;

    //to make the enemy stop when it hits the bomb
    private bool isMoving = true;
    private bool movinForward = true;
    private int waypointDestination = 0;


    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    //FixedUpdate - its only going to run on the physics frames
    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * moveSpeed);

        if (isMoving)
        {
            myRigidBody.MovePosition(Vector3.MoveTowards(transform.position, target[waypointDestination].position, Time.deltaTime * moveSpeed)); //less isues
            if (Vector3.Distance(transform.position, target[waypointDestination].position) < 0.1f)
            {
                if (movinForward)
                {
                    if (waypointDestination >= target.Length - 1)
                    {
                        movinForward = false;
                        waypointDestination--;
                    }
                    else //if enemy is moving forward and has not reached the last waypoint in the array
                    {
                        waypointDestination++;
                    }
                }
                //enemy is moving backwords
                else
                {
                    if (waypointDestination <= 0)
                    {
                        movinForward = true;
                        waypointDestination++;
                    }
                    else //if the enemy is moving backwords has not reached the first waypoint in the array
                    {
                        waypointDestination--;
                    }
                }

            }
        }
   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isMoving = false;
            Debug.Log("Hit player");
        }

        if (collision.gameObject.tag == "Bomb")
        {
            isMoving = false;
            Debug.Log("Hit bomb");
        }

        //collision action matrix - in documentation
    }
}
