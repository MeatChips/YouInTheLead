using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pet : MonoBehaviour
{
    public DateTime lastTimeFed, lastTimeHappy, lastTimeEnergized;
    public int food, happiness, energy;

    public Pet(DateTime lastTimeFed, DateTime lastTimeHappy, DateTime lastTimeEnergized, int food, int happiness, int energy)
    {
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeEnergized = lastTimeEnergized;
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
    }
}
