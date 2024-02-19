using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI txtEnerge;
    public TextMeshProUGUI txtGold;
    public TextMeshProUGUI txtGem;


    private double userEnerge;
    private double userGold;
    private double userGem;


    public TextMeshProUGUI txtHero;





    void Start()
    {
        userGold = 1000;
        txtGold.text = userGold.ToString();
        userGem = 0;
        txtGem.text = userGem.ToString();
        userEnerge = 0/5;
        txtEnerge.text = userEnerge.ToString();
    }

    public void Attack()
    {

    }



   
}
