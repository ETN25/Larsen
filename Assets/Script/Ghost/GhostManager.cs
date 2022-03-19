using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public int race;
    [SerializeField] float interactionTimer;
    [SerializeField] float interactionCooldown;
    public SoundManager Player;

    // Start is called before the first frame update
    void Start()
    {
        race = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
        }
    }
}
