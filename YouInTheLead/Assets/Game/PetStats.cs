using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetStats : MonoBehaviour
{
    [Header("HEALTH")]
    public int maxHealth = 100;
    public int currentHealth;

    [Header("REGENERATION")]
    public int regenerationNotificationHealth = 5;
    public int regenerationEatHealth = 2;

    [Header("OTHER SCRIPTS")]
    public Healthbar healthbar;
    public Notification notificationScript;

    [Header("BUTTONS")]
    public Button notificationButton;
    public Button eatButton;

    [Header("SPRITES")]
    public Sprite baby_pet_sick_50hp;
    public Sprite kid_pet_sick_50hp;
    public Sprite adult_pet_sick_50hp;

    public Sprite baby_pet;
    public Sprite kid_pet;
    public Sprite adult_pet;

    [Header("SPRITERENDERER")]
    public SpriteRenderer spriteRenderer;

    [Header("TIMERS")]
    public float timer = 0.0f;
    public int seconds;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        Button btn = notificationButton.GetComponent<Button>();
        btn.onClick.AddListener(HealHP);

        Button btn2 = eatButton.GetComponent<Button>();
        btn2.onClick.AddListener(PetEat);
    }

    // Update is called once per frame
    void Update()
    {
        // seconds in float
        timer += Time.deltaTime;
        // turn seconds in float to int
        seconds = (int)(timer % 60);
        print(seconds);

        if (notificationScript.elapsed == 0)
        {
            TakeDamage(5);
        }

        // Baby
        if (currentHealth == 50)
        {
            spriteRenderer.sprite = baby_pet_sick_50hp;
        }

        // Kid
        if (seconds > 60)
        {
            spriteRenderer.sprite = kid_pet;
        }

        if (currentHealth == 50 && seconds > 60)
        {
            spriteRenderer.sprite = kid_pet_sick_50hp;
        }

        // Adult
        if (seconds > 120)
        {
            spriteRenderer.sprite = adult_pet;
        }

        if (currentHealth == 50 && seconds > 120)
        {
            spriteRenderer.sprite = adult_pet_sick_50hp;
        }
    }

    public void PetEat()
    {
        if (currentHealth == maxHealth)
        {
            regenerationEatHealth = 0;

            Debug.Log("The pet's stomach is full.");
        }
        else
        {
            currentHealth += regenerationEatHealth;
            healthbar.SetHealth(currentHealth);

            Debug.Log("Pet has been given food. Pet is happy.");
        }
    }

    void HealHP()
    {
        if (currentHealth == maxHealth)
        {
            regenerationNotificationHealth = 0;

            Debug.Log("You've clicked enough notifications.");
        }
        else
        {
            currentHealth += regenerationNotificationHealth;
            healthbar.SetHealth(currentHealth);

            Debug.Log("Your pet has been healed a bit!");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
