using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseShadow : MonoBehaviour
{
    public Transform Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 look = new Vector3(Player.position.x, 1f, Player.position.z);
        transform.LookAt(look);
        
    }
}
