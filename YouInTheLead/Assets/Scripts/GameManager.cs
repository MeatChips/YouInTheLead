using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text notificationText;

    public float timer = 5.0f;

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("clickButton", 20f, 20f);
    }

    

   public void clickButton()
   {
       StartCoroutine(sendNotification("Notification!!", 3));
   }

    IEnumerator sendNotification(string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }
}
