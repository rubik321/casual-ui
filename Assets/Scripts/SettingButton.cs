using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imFocus;


    // Update is called once per frame
    public void SetFocus(bool focus)
    {
        imFocus.gameObject.SetActive(focus);
    }
}
