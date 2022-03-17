using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetUIController : MonoBehaviour
{
    public Image foodImage;
    public Image drinkImage;
    public Image happinessImage;

    public static PetUIController instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More then one PetUIController in the scene");
    }

    public void UpdateImages(int food, int happiness, int drink)
    {
        foodImage.fillAmount = (float) food / 100;
        drinkImage.fillAmount = (float)drink / 100;
        happinessImage.fillAmount = (float)happiness / 100;
    }
}
