using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderParameter : MonoBehaviour
{
    public GameObject Player, TxtValue;
    float value;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Slider>().value = Player.GetComponent<MouseLook>().sensitivityX;
    }

    // Update is called once per frame
    void Update()
    {
        value = gameObject.GetComponent<Slider>().value * 10;
        TxtValue.GetComponent<Text>().text = value.ToString();
        Player.GetComponent<MouseLook>().sensitivityX = gameObject.GetComponent<Slider>().value;
    }
}
