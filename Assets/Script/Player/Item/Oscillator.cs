using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public AudioSource sound;
    PlayerController controls;
    PlayerController.ActionActions action;
    public bool On = false;

    [SerializeField] GhostManager ghost;
    [SerializeField] int race;

    [SerializeField] float CoolDown;
    [SerializeField] float NextInteraction;


    private void Awake()
    {
        controls = new PlayerController();
        action = controls.Action;
        action.Item.performed += _ => OnOff();
    }

    void Start()
    {
        race = ghost.race;
        NextInteraction = Random.Range(1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (On)
        {
            if (race == 1 || race == 3)
            {
                CoolDown += 1 * Time.deltaTime;
                if (CoolDown > NextInteraction)
                {
                    sound.pitch = sound.pitch + Random.Range(-15f, 20f) * Time.deltaTime;
                }
                if (CoolDown > (NextInteraction + Random.Range(5, 10)))
                {
                    CoolDown = 0f;
                    NextInteraction = Random.Range(10f, 120f);
                    sound.pitch = 1;
                }
                if(sound.pitch > 2)
                {
                    sound.pitch = 2f - Random.Range(0.1f, 0.5f);
                }
                if (sound.pitch < -3)
                {
                    sound.pitch = -3;
                }
            }
        }
        else
        {
            CoolDown = 0f;
            sound.pitch = 1;
        }
    }

    public void OnOff()
    {
        if (On)
        {
            On = false;
            sound.Stop();
        }
        else
        {
            On = true;
            sound.Play();
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
