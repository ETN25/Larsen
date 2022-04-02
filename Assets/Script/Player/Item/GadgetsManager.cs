using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GadgetsManager : MonoBehaviour
{

    public int OS, SB, BP;
    [SerializeField] GameObject oscillator, spiritbox, bipor;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OS == 1)
        {
            oscillator.SetActive(true);
        }
        else
        {
            oscillator.SetActive(false);
            OS = 0;
        }
        if (SB == 1)
        {
            spiritbox.SetActive(true);
        }
        else
        {
            spiritbox.SetActive(false);
            SB = 0;
        }
        if (BP == 1)
        {
            bipor.SetActive(true);
        }
        else
        {
            bipor.SetActive(false);
            BP = 0;
        }

    }

    public void item1()
    {
        OS += 1;
        SB = 0;
        BP = 0;
    }
    public void item2()
    {
        SB += 1;
        OS = 0;
        BP = 0;
    }
    public void item3()
    {
        BP += 1;
        OS = 0;
        SB = 0;
    }
}
