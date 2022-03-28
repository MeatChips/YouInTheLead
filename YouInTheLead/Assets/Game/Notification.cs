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

    public Text notificationButtonText;
    public Button notificationButton;

    public string notificationTextWrite;
    public string notificationButtonTextWrite;

    void Start()
    {
        Button btn = notificationButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

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
        StartCoroutine(sendNotification("Notification!!", "CLICK HERE", 10));
    }

    IEnumerator sendNotification(string text, string text1, int time)
    {
        notificationText.text = text;
        notificationButtonText.text = text1;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
        notificationButtonText.text = "";
    }
}
