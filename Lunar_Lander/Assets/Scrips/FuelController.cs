using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    [SerializeField] Text fuel_Text;
    float currentFuel = 100;

    public void SpendFuel(float value)
    {
        currentFuel -= value;
    }
    public float getCurrentFuel()
    {
        return currentFuel;
    }
    private void Update()
    {
        fuel_Text.text = Math.Truncate(currentFuel).ToString();
    }
}
