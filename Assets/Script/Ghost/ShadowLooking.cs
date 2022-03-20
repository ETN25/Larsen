using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowLooking : MonoBehaviour
{
    public Transform Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 look = new Vector3(Player.position.x, 1.5f, Player.position.z);
        transform.LookAt(Player);
    }
}
