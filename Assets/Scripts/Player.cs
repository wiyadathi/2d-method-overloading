using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health = 100;
    public int Health => health; 

    float strength = 10.0f;
    public float Strength => strength;

    float speed = 5.0f;
    public float Speed => speed;

    float originalSpeed;
    float speedBoostDuration = 0.0f;  // How long the boost lasts
    float speedBoostTimer = 0.0f; // to track how much time has passed since the speed boost was activated.
    bool isSpeedBoostActive = false; // tracks whether the speed boost is currently active or not.


    void Start()
    {
        originalSpeed = speed;

    }

    void Update()
    {
        UpdateSpeedBoostTimer();
    }

    void UpdateSpeedBoostTimer()
    {
        if (isSpeedBoostActive)
        {
            speedBoostTimer += Time.deltaTime;
            Debug.Log("+++Speed Boost...");
            if (speedBoostTimer >= speedBoostDuration)
            {
                speed = originalSpeed;
                isSpeedBoostActive = false;
                Debug.Log("Speed boost ended. Speed reset.");

            }
        }
    }

    public void PowerUp(int healthIncrease)
    {
        health += healthIncrease;
        Debug.Log($"Health increased by {healthIncrease}. New health: {health}");
    }

    public void PowerUp(float strengthMultiplier)
    {
        strength *= strengthMultiplier;
        Debug.Log($"Strength  increased by {strengthMultiplier*100}%. New Strength: {strength}");
    }
    public void PowerUp(float speedMultiplier, float duration)
    {
        if (!isSpeedBoostActive)
        {
            speed *= speedMultiplier;
            isSpeedBoostActive = true;
            speedBoostDuration = duration;
            speedBoostTimer = 0.0f;
            Debug.Log($"Speed boosted by {speedMultiplier * 100}% for {duration} seconds.");
        }
    }


}
