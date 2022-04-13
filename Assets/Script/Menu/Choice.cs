using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choice : MonoBehaviour
{
    [SerializeField] Toggle OS, SP, BP;
    [SerializeField] GameObject BH, MR, PG, Confirm, Ghost;
    [SerializeField] int race;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BH.SetActive(false);
        MR.SetActive(false);
        PG.SetActive(false);
        Confirm.SetActive(false);
        if (OS.isOn && SP.isOn && !BP.isOn)
        {
            race = 1;
            BH.SetActive(true);
            Confirm.SetActive(true);
        }
        if (SP.isOn && BP.isOn && !OS.isOn)
        {
            race = 2;
            MR.SetActive(true);
            Confirm.SetActive(true);
        }
        if (OS.isOn && BP.isOn && !SP.isOn)
        {
            race = 3;
            PG.SetActive(true);
            Confirm.SetActive(true);
        }
    }

    public void confirm()
    {
        if (race == Ghost.GetComponent<GhostManager>().race)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            SceneManager.LoadScene("Loose");
        }
    }
}
