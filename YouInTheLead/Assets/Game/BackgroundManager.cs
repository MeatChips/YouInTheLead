using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    [Header("SPRITERENDERER")]
    public SpriteRenderer spriteRenderer;

    [Header("BACKGROUND SPRITES")]
    public Sprite newBackgroundSprite_100HP;
    public Sprite newBackgroundSprite_50HP;

    [Header("OTHER SCRIPTS")]
    public PetStats PetStatsScript;

    // Update is called once per frame
    public void Update()
    {
        if (PetStatsScript.currentHealth == 100)
        {
            spriteRenderer.sprite = newBackgroundSprite_100HP;
        }

        if (PetStatsScript.currentHealth == 50)
        {
            spriteRenderer.sprite = newBackgroundSprite_50HP;
        }
    }
}
