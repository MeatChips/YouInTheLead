using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pet : MonoBehaviour
{
    public DateTime lastTimeFed, lastTimeHappy, lastTimeDrinked;
    public int food, happiness, drink;

    public Pet(DateTime lastTimeFed, DateTime lastTimeHappy, DateTime lastTimeDrinked, int food, int happiness, int drink)
    {
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeDrinked = lastTimeDrinked;
        this.food = food;
        this.happiness = happiness;
        this.drink = drink;
    }
}
