using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] int on;
    public Light torch;
    public bool glitchOn;
    [SerializeField] float glitchCD;
    [SerializeField] float glitchTimer;

    // Start is called before the first frame update
    void Start()
    {
        on = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (on == 1)
        {
            torch.intensity = 1f;
        }
        else
        {
            on = 0;
            torch.intensity = 0.1f;
        }
        if (glitchOn)
        {
            if (glitchTimer >= glitchCD)
            {
                on += 1;
                glitchTimer = 0f;
                glitchCD = Random.Range(0f, 0.2f);
            }
            glitchTimer += 1 * Time.deltaTime;
        }
    }

    public void OnOff()
    {
        on += 1;
        if (glitchOn)
        {
            on = 0;
            glitchOn = false;
        }
    }
}
