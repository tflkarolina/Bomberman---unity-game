using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Debug.Log("player name: " + player.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log(other.gameObject.name);
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //}
}
