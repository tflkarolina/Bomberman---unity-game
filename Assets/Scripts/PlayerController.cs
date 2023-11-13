using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float xMoveSpeed; //serialize field so we hve the acces to change the moveSpeed directly from unity
    [SerializeField] float yMoveSpeed;
    [SerializeField] float zMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPlayerPosition = new Vector3(0, 0, 0);
        transform.position += newPlayerPosition;
    }

    // Update is called once per frame
    void Update()
    {   //Debug.Log(Time.deltaTime);
        //transform.Translate(xMoveSpeed * Time.deltaTime, yMoveSpeed * Time.deltaTime, zMoveSpeed * Time.deltaTime);


        Movement();
    }

    private void Movement()
    {
        Vector3 newPosition = new Vector3();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            newPosition = new Vector3(0f, 0f, zMoveSpeed);
            //transform.Translate(0f, 0f, zMoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newPosition = new Vector3(0f, 0f, -zMoveSpeed);
            //transform.Translate(0f, 0f, -zMoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition = new Vector3(xMoveSpeed, 0f, 0f);
            //transform.Translate(xMoveSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition = new Vector3(-xMoveSpeed, 0f, 0f);
            //transform.Translate(-xMoveSpeed * Time.deltaTime, 0f, 0f);
        }

        transform.position += newPosition * Time.deltaTime;
    }

}
