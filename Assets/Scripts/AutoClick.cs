using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AutoClick : MonoBehaviour
{


    public bool IsAuto = false;
    // Start is called before the first frame update
    void Start()
    {
        Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        this.IsAuto = !this.IsAuto;
    }
}
