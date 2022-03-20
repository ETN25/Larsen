using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public int race;
    [SerializeField] float interactionTimer;
    [SerializeField] float interactionCooldown;
    [SerializeField] float Selection;
    [SerializeField] Lamp lamp;
    public AudioSource Breath;
    [SerializeField] GameObject shadow;

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
            Selection = Random.Range(0f, 10f);
            if (race == 1)
            {
                if (Selection < 3f)
                {
                    Shadow();
                }
                if ( 3f <= Selection && Selection < 6f)
                {
                    Glitch();
                }
                if (Selection > 6f) //Plus courant
                {
                    Whisper();
                }
            }
            if (race == 2)
            {
                if (Selection < 3f)
                {
                    Whisper();
                }
                if (3f <= Selection && Selection < 6f)
                {
                    Glitch();
                }
                if (Selection > 6f) //Plus courant
                {
                   Shadow();
                }
            }
            if (race == 3)
            {
                if (Selection < 3f)
                {
                    Shadow();
                }
                if (3f <= Selection && Selection < 6f)
                {
                    Whisper();
                }
                if (Selection > 6f) //Plus courant
                {
                    Glitch(); 
                }
            }
        }
    }

    private void Shadow()
    {
        print("1");
        Instantiate(shadow, new Vector3(transform.position.x + Random.Range(-3f, 3f), 1.2f, transform.position.z + Random.Range(-3f, 3f)), transform.rotation);
    }

    private void Glitch()
    {
        lamp.glitchOn = true;
        print("2");
    }
    private void Whisper()
    {
        print("3");
        Breath.Play();
    }

}
