using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    private Database database;
    public PetController petController;

    private void Awake()
    {
        database = new Database();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More then one DatabaseManager is in the scene.");
    }

    private void Start()
    {
        Pet pet = LoadPet();
        if(pet != null) Debug.Log(LoadPet().drink);
    }

    private void Update()
    {
        if(TimeManager.gameHourTimer < 0)
        {
            Pet pet = new Pet(petController.lastTimeFed, petController.lastTimeHappy, petController.lastTimeDrinked, petController.food, petController.happiness, petController.drink);
            SavePet(pet);
        }
    }

    public void SavePet(Pet pet)
    {
        database.SaveData("pet", pet);
    }

    public Pet LoadPet()
    {
        Pet returnValue = null;
        database.LoadData<Pet>("pet", (pet) =>
        {
            returnValue = pet;

        });
        return returnValue;
    }
}
