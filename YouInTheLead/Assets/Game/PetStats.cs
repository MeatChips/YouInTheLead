using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int regenerationHealth = 5;

    public Healthbar healthbar;
    public Notification notificationScript;

    public Button notificationButton;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        Button btn = notificationButton.GetComponent<Button>();
        btn.onClick.AddListener(HealHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (notificationScript.elapsed == 0)
        {
            TakeDamage(5);
        }
    }

    void HealHP()
    {
        currentHealth += regenerationHealth;
        healthbar.SetHealth(currentHealth);

        Debug.Log("Your pet has been healed a bit!");
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
