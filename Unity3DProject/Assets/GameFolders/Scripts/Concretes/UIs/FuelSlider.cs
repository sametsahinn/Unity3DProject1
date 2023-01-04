using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSlider : MonoBehaviour
{
    Slider slider;
    Fuel fuel;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        fuel = FindObjectOfType<Fuel>();
    }

    private void Update()
    {
        slider.value = fuel.CurrentFuel;
    }
}
