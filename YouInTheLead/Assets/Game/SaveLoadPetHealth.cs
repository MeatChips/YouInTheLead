using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadPetHealth : MonoBehaviour
{
    public Slider healthSlider;
    float healthAmount;

    void Start()
    {
        healthAmount = PlayerPrefs.GetFloat("healthAmount");
        healthSlider.value = healthAmount;
    }
    public void SaveThis()
    {
        healthAmount = healthSlider.value;
        PlayerPrefs.SetFloat("healthAmount", healthAmount);
    }
}
