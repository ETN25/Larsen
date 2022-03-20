using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    [SerializeField] Transform Ghost;
    [SerializeField] AudioSource Sound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distance = new Vector2(Ghost.position.x - transform.position.x, Ghost.position.z - transform.position.z);
        if(distance.magnitude <= 2)
        {
            Sound.pitch = 1.1f;
            Sound.volume = 0.8f;
        }
        else
        {
            Sound.pitch = 1f;
            Sound.volume = 0.5f;
        }
    }
}
