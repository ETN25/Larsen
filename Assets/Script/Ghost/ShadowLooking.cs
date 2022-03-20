using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowLooking : MonoBehaviour
{
    public Transform Player;
    
    void Start()
    {
        Player = FindObjectOfType<InputManager>().transform;
        Destroy(gameObject, 1.5f);
        transform.position = new Vector3(transform.position.x, 1.45f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 look = new Vector3(Player.position.x, 1.8f, Player.position.z);
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
        transform.LookAt(Player);
    }
}
