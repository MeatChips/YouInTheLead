using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newBackgroundSprite0;
    public Sprite newBackgroundSprite1;
    public Sprite newBackgroundSprite2;
    public Sprite newBackgroundSprite3;
    public Sprite newBackgroundSprite4;

    public PetStats PetStatsScript;

    // Update is called once per frame
    public void Update()
    {
        if (PetStatsScript.currentHealth == 100)
        {
            spriteRenderer.sprite = newBackgroundSprite0;
        }

        if (PetStatsScript.currentHealth == 75)
        {
            spriteRenderer.sprite = newBackgroundSprite1;
        }

        if (PetStatsScript.currentHealth == 50)
        {
            spriteRenderer.sprite = newBackgroundSprite2;
        }

        if (PetStatsScript.currentHealth == 25)
        {
            spriteRenderer.sprite = newBackgroundSprite3;
        }

        if (PetStatsScript.currentHealth == 0)
        {
            spriteRenderer.sprite = newBackgroundSprite4;
        }
    }
}
