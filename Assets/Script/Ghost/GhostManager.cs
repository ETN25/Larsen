using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public int race;
    [SerializeField] float interactionTimer;
    [SerializeField] float interactionCooldown;
    [SerializeField] float Selection;
    [SerializeField] GameObject Player;
    public AudioSource Breath;

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
        print("yo");
        if (other.CompareTag("Player"))
        {
            Selection = Random.Range(0f, 10f);
            if (race == 1)
            {
                if (Selection < 3f)
                {
                    //Lampe
                }
                if ( 3f <= Selection && Selection < 6f)
                {
                    //Ombre
                }
                if (Selection > 6f) //Plus courant
                {
                    Breath.Play();
                }
            }
        }
    }
}
