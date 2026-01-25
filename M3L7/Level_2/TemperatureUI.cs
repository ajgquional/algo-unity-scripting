/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Updates the Player's temperature on the UI.
 * 
 * How to use:
 *      - Attach the script to the Player in Level 2
 *      - Link the Temperature instance of the Player
 *      - Link the temperature text
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;    // library for working with TextMeshPro

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;         // refers to the instance of the Player's temp class
    public TextMeshProUGUI temperatureText; // refers to object containing the TextMeshPro component

    // continuously update the temperature text in the UI, every frame
    void Update()
    {
        // rounds off the temperature before assigning it to the text property of the temperatureText
        float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        temperatureText.text = roundTemperature.ToString();
    }
}
