using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText;
    public Image slider;
    public float timeLimit = 60f;

    float time = 0;

    public AutoClick AutoClick;

    private void Start()
    {
        timeLimit = (int)UnityEngine.Random.Range(10f, 20f);
        time = 0;
        timeText.text = time.ToString();
        slider.fillAmount = time / timeLimit;
    }

    private void Update()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
            timeText.text = ((int)time).ToString();
            slider.fillAmount = time / timeLimit;
        }
        else if (this.AutoClick.IsAuto) this.OnClick();


    }
    public void OnClick()
    {
        timeText.text = timeLimit.ToString();
        time = timeLimit;
        slider.fillAmount = time / timeLimit;
    }
}
