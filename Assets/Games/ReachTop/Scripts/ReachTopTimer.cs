using UnityEngine;
using UnityEngine.UI;
using System;

public class ReachTopTimer : MonoBehaviour
{
    public float TimerTime = 3;
    public Text TimerText;
    public Text butonButtonForPlayerBlue;
    public Text butonButtonForPlayerRed;

    void Update()
    {
        if (TimerTime < 0.5f)
        {
            Destroy(TimerText.gameObject);
            Destroy(butonButtonForPlayerBlue.gameObject);
            Destroy(butonButtonForPlayerRed.gameObject);
        }
        else
        {
            TimerText.text = Math.Round(TimerTime).ToString();
            TimerTime -= Time.deltaTime;
        }
    }
}
