using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public AudioSource sound;
    PlayerController controls;
    PlayerController.ActionActions action;
    public bool On = false;

    [SerializeField] GhostManager ghostManager;
    [SerializeField] GameObject Ghost;
    [SerializeField] int race;

    [SerializeField] float CoolDown;
    [SerializeField] float NextInteraction;

    public Material M_ON, M_OFF;
    public GameObject LED;

    private void Awake()
    {
        controls = new PlayerController();
        action = controls.Action;
        action.Item.performed += _ => OnOff();
    }

    void Start()
    {
        race = ghostManager.race;
        NextInteraction = Random.Range(10f, 120f);
    }

    // Update is called once per frame
    void Update()
    {
        if (On && Vector3.Distance(Ghost.transform.position, transform.position) < 8f)
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
            Ghost.GetComponent<Chase>().AngerLevel += 1 * Time.deltaTime;
        }
        else
        {
            
            sound.pitch = 1;
        }
    }

    public void OnOff()
    {
        if (On)
        {
            ItemOff();
        }
        else
        {
            ItemOn();
        }
    }

    public void ItemOn()
    {
        On = true;
        sound.Play();
        LED.GetComponent<MeshRenderer>().material = M_ON;
    }

    public void ItemOff()
    {
        On = false;
        sound.Stop();
        LED.GetComponent<MeshRenderer>().material = M_OFF;
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
