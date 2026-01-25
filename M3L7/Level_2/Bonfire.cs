/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements the operation of the bonfire. Aside 
 *      from reducing the fire of the bonfire, the 
 *      Player needs to go near the bonfire for his/her 
 *      temperature to increase.
 * 
 * How to use:
 *      - Add a collider to all bonfires in Level 2 
 *          and make the collider a trigger 
 *          (recommended to edit the prefab)
 *      - Attach the script to all bonfires
 *          (recommended to edit the prefab)
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime = 15;     // default lifetime of the bonfire
    public float heatPower = 0.1f;  // heat to be given to the Player

    // continuously reduce the lifetime of the bonfire every frame
    void Update()
    {
        // reducing the lifetime of the bonfire
        lifeTime -= Time.deltaTime;

        // if the lifetime of the bonfire goes down to zero, deactivate the bonfire
        // thereby "extinguishing" the fire
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    // while the Player stays within the bonfire's Collider, increase the Player's temp
    void OnTriggerStay(Collider other)
    {
        // checks if there is a Temperature component in the Player
        if (other.GetComponent<Temperature>() != null)
        {
            // actually getting the Temperature component
            Temperature temperature = other.GetComponent<Temperature>();

            // checks if the current temp of the Player is below normal
            if (temperature.temperatureCurrent < temperature.temperatureNormal)
            {
                // if current temp is below normal, warm up the Player
                temperature.temperatureCurrent += heatPower * Time.deltaTime;
            }
        }
    }
}
