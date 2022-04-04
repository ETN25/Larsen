using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritBox : MonoBehaviour
{
    public AudioSource sound, voice;
    PlayerController controls;
    PlayerController.ActionActions action;
    public bool On = false;

    [SerializeField] GhostManager ghost;
    [SerializeField] Transform ghostPosition;
    [SerializeField] int race;

    [SerializeField] float CoolDown;
    [SerializeField] float NextInteraction;

    public Material M_ON, M_OFF;
    public GameObject LED;

    bool played = false;


    private void Awake()
    {
        controls = new PlayerController();
        action = controls.Action;
        action.Item.performed += _ => OnOff();
    }

    void Start()
    {
        race = ghost.race;
        NextInteraction = Random.Range(10f, 120f);
    }

    // Update is called once per frame
    void Update()
    {
        if (On && Vector3.Distance(ghostPosition.position, transform.position) < 8f)
        {
            if (race == 2 || race == 1)
            {
                CoolDown += 1 * Time.deltaTime;
                if (CoolDown > NextInteraction)
                {
                    if (!played)
                    {
                        voice.Play();
                        played = true;
                    }
                }
                if (CoolDown > (NextInteraction + 8))
                {
                    CoolDown = 0f;
                    NextInteraction = Random.Range(10f, 120f);
                    played = false;
                }

            }
        }
        else
        {
            CoolDown = 0f;
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

