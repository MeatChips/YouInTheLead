using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public int food;
    public int happiness;
    public int energy;

    public int foodTickRate;
    public int happinessTickRate;
    public int energyTickRate;

    public DateTime lastTimeFed, lastTimeHappy, lastTimeEnergized;

    public void Awake()
    {
        Initiziale(100, 100, 100, 2, 1, 1);
    }

    public void Initiziale(int food, int happiness, int energy, int foodTickRate, int happinessTickRate, int energyTickRate)
    {
        lastTimeFed = DateTime.Now;
        lastTimeHappy = DateTime.Now;
        lastTimeEnergized = DateTime.Now;
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.energyTickRate = energyTickRate;
    }

    private void Update()
    {
        if(TimeManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappiness(-happinessTickRate);
            ChangeEnergy(-energyTickRate);
        }
    } 
    public void ChangeFood(int amount)
    {
        food += amount;
        if(food > 0)
        {
            lastTimeFed = DateTime.Now;
        }

        if (food < 0)
        {
            PetManager.PetDeathFood();
        }
        else if (food > 100) food = 100;
    }

    public void ChangeHappiness(int amount)
    {
        happiness += amount;
        if (happiness > 0)
        {
            lastTimeHappy = DateTime.Now;
        }

        if (happiness < 0)
        {
            PetManager.PetDeathHappiness();
        }
        else if (happiness > 100) happiness = 100;
    }

    public void ChangeEnergy(int amount)
    {
        energy += amount;
        if (energy > 0)
        {
            lastTimeEnergized = DateTime.Now;
        }

        if (energy < 0)
        {
            PetManager.PetDeathEnergy();
        }
        else if (energy > 100) energy = 100;
    }
}
