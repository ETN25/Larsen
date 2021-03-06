using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    [SerializeField] GameObject Ghost;
    [SerializeField] AudioSource Sound, chaseSound;
    private bool played;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        played = false;
        Vector2 distance = new Vector2(Ghost.transform.position.x - transform.position.x, Ghost.transform.position.z - transform.position.z);
        if (distance.magnitude <= 2)
        {
            Sound.pitch = 1.1f;
            Sound.volume = 0.5f;
        }
        else
        {
            Sound.pitch = 1f;
            Sound.volume = 0.2f;
        }

    }
}
