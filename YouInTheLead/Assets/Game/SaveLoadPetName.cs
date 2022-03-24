using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadPetName : MonoBehaviour
{
    public InputField inputText;
    string petText;

    void Start()
    {
        petText = PlayerPrefs.GetString("PetName");
        inputText.text = petText;
    }
    public void SaveThis()
    {
        petText = inputText.text;
        PlayerPrefs.SetString("PetName", petText);
    }
}
