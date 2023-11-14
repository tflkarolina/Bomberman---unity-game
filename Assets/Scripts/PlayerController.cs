using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float xMoveSpeed; //serialize field so we hve the acces to change the moveSpeed directly from unity
    [SerializeField] float yMoveSpeed;
    [SerializeField] float zMoveSpeed;

    Rigidbody myRigidBody;

    [SerializeField] GameObject bombPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 newPlayerPosition = new Vector3(0, 0, 0);
        //transform.position += newPlayerPosition;

        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   //Debug.Log(Time.deltaTime);
        //transform.Translate(xMoveSpeed * Time.deltaTime, yMoveSpeed * Time.deltaTime, zMoveSpeed * Time.deltaTime);

        Movement();
        PlaceBomb();
    }

    private void Movement()
    {
        Vector3 newVelocity = new Vector3();
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            newVelocity = new Vector3(0f, 0f, zMoveSpeed);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newVelocity = new Vector3(0f, 0f, -zMoveSpeed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newVelocity = new Vector3(xMoveSpeed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newVelocity = new Vector3(-xMoveSpeed, 0f, 0f);
            //transform.Translate(-xMoveSpeed * Time.deltaTime, 0f, 0f);
        }


        myRigidBody.velocity = newVelocity;
        //GetComponent<Rigidbody>().velocity = newPosition;


        //transform.position += newPosition * Time.deltaTime;
    }

    private void PlaceBomb()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //UnityEngine.Debug.Log("Bomb placed!");
            GameObject bomb = Instantiate(bombPrefab, transform.position, Quaternion.identity);
            
        }
                                
    }

}
