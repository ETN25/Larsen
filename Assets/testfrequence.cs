using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testfrequence : MonoBehaviour
{
    public AudioSource son;
    public float pitch = 1;
    public float changement = 1;

    public float CD;
    public int signe;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CD += 1 * Time.deltaTime;
        son.pitch += Random.Range(0f, 5f) * signe * Time.deltaTime;
        if (CD > changement)
        {
            CD = 0f;
            changement = Random.Range(0f, 0.5f);
            signe = signe * -1;
            son.Play();
        }
        if (son.pitch > 3)
        {
            son.pitch = 3;
        }
        if (son.pitch < -3)
        {
            son.pitch = -3;
        }
        

    }
}
