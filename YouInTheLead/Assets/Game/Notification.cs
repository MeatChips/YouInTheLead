using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    [SerializeField]
    public float timerSpeed;

    public Text notificationText;

    public float elapsed;

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timerSpeed)
        {
            elapsed = 0f;
            NotificationGo();
        }
    }

    public void NotificationGo()
    {
        StartCoroutine(sendNotification("Notification!!", 10));
    }

    IEnumerator sendNotification(string text, int time)
    {
        notificationText.text = text;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
    }
}
