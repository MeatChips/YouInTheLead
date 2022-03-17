using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour
{
    public PetController petController;

    public static void PetDeathFood()
    {
        Debug.Log("Pet starved to death");
    }

    public static void PetDeathHappiness()
    {
        Debug.Log("Pet commited suicide");
    }

    public static void PetDeathThirst()
    {
        Debug.Log("Pet driedd out");
    }

}
