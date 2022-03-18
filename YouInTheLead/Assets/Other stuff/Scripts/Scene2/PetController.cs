using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PetController : MonoBehaviour
{
    public int food;
    public int happiness;
    public int drink;

    public int foodTickRate;
    public int happinessTickRate;
    public int drinkTickRate;

    public DateTime lastTimeFed, lastTimeHappy, lastTimeDrinked;

    public void Awake()
    {
        Initiziale(100, 100, 100, 1, 1, 1);
    }

    public void Initiziale(int food, int happiness, int drink, int foodTickRate, int happinessTickRate, int drinkTickRate)
    {
        lastTimeFed = DateTime.Now;
        lastTimeHappy = DateTime.Now;
        lastTimeDrinked = DateTime.Now;
        this.food = food;
        this.happiness = happiness;
        this.drink = drink;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.drinkTickRate = drinkTickRate;
        PetUIController.instance.UpdateImages(food, happiness, drink);
    }

    public void Initiziale(int food, int happiness, int drink, int foodTickRate, int happinessTickRate, int drinkTickRate, DateTime lastTimeFed, DateTime lastTimeHappy, DateTime lastTimeDrinked)
    {
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeDrinked = lastTimeDrinked;
        this.food = food;
        this.happiness = happiness;
        this.drink = drink;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.drinkTickRate = drinkTickRate;
        PetUIController.instance.UpdateImages(food, happiness, drink);
    }

    private void Update()
    {
        if(TimeManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappiness(-happinessTickRate);
            ChangeDrink(-drinkTickRate);
            PetUIController.instance.UpdateImages(food, happiness, drink);
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

    public void ChangeDrink(int amount)
    {
        drink += amount;
        if (drink > 0)
        {
            lastTimeDrinked = DateTime.Now;
        }

        if (drink < 0)
        {
            PetManager.PetDeathThirst();
        }
        else if (drink > 100) drink = 100;
    }
}
