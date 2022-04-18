using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadDayInfo : MonoBehaviour
{
    public InputField inputText;
    string dayInfoText;

    void Start()
    {
        dayInfoText = PlayerPrefs.GetString("DayInfo");
        inputText.text = dayInfoText;
    }
    public void SaveThis()
    {
        dayInfoText = inputText.text;
        PlayerPrefs.SetString("DayInfo", dayInfoText);
    }
}
