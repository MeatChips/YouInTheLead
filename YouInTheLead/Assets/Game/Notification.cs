using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    [SerializeField]
    [Header("TIMERS")]
    public float timerSpeed;

    [Header("TEXT")]
    public Text notificationText;
    public Text notificationButtonText;

    [Header("ELAPSED")]
    public float elapsed;

    [Header("BUTTONS")]
    public Button notificationButton;

    [Header("WRITABLE BUTTONS")]
    public string notificationTextWrite;
    public string notificationButtonTextWrite;

    [Header("STRINGS")]
    private string input;

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
    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

    public void NotificationGo()
    {
        StartCoroutine(sendNotification(input, "CLICK HERE", 10));
    }

    IEnumerator sendNotification(string s, string text1, int time)
    {
        input = s;
        notificationText.text = input;
        notificationButtonText.text = text1;
        yield return new WaitForSeconds(time);
        notificationText.text = "";
        notificationButtonText.text = "";
    }
}
