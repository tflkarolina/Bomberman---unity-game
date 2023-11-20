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
            myRigidBody.MovePosition(Vector3.MoveTowards(transform.position, target[0].position, Time.deltaTime * moveSpeed)); //less isues
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
