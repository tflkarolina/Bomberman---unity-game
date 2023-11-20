using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives = 3;

    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerParentTranform;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity, playerParentTranform);       //Quaternion.identity - means no rotation
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
