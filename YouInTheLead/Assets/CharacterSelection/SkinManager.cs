using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
    [Header("SPRITERENDERER")]
    public SpriteRenderer sr;

    [Header("LISTS")]
    public List<Sprite> skins = new List<Sprite>();

    [Header("SKINS")]
    private int selectedSkin = 0;

    [Header("PLAYERSKIN -> PREFABS")]
    public GameObject playerskin;

    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if(selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Sprites/selectedskin.prefab");
        SceneManager.LoadScene("Scene3");
    }
}
