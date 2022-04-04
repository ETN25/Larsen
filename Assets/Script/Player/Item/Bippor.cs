using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bippor : MonoBehaviour
{
    public AudioSource sound;
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

    public float distance;

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
        distance = Vector3.Distance(ghostPosition.position, transform.position);
        print(distance);
        if (On && Vector3.Distance(ghostPosition.position, transform.position) < 8f)
        {
            if (race == 2 || race == 3)
            {
                CoolDown += 1 * Time.deltaTime;
                if (CoolDown > NextInteraction)
                {
                    sound.Stop();
                }
                if (CoolDown > (NextInteraction + Random.Range(5, 10)))
                {
                    CoolDown = 0f;
                    NextInteraction = Random.Range(10f, 120f);
                    sound.Play();
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
