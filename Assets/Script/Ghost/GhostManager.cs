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
    [SerializeField] GameObject shadow, player;
    public bool Chasing;

    // Start is called before the first frame update
    void Start()
    {
        race = Random.Range(1, 4);
        interactionCooldown = Random.Range(10f, 60f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Chasing)
        {
            interactionTimer += 1 * Time.deltaTime;
            if (interactionCooldown <= interactionTimer)
            {
                if (Vector3.Distance(player.transform.position, transform.position) < 4f)
                {
                    Action();
                    interactionCooldown = Random.Range(10f, 60f);
                    interactionTimer = 0f;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Player"))
        {
            
        }
    }


    private void Action()
    {
        Selection = Random.Range(0f, 10f);
        if (race == 1)
        {
            if (Selection < 3f)
            {
                Shadow();
            }
            if (3f <= Selection && Selection < 6f)
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

    private void Shadow()
    {
        print("1");
        Instantiate(shadow, transform);
    }

    public void Glitch()
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
