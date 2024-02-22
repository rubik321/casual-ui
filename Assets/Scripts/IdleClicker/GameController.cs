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

    public TextMeshProUGUI txtWaveStar;
    public TextMeshProUGUI txtWaveFinish;

    public double userWaveStar;
    public double userWaveFinish;
    public BossItem bossItem;

    public DataPlayerController dataPlayerController;

    public int Level; // biến đếm độ khó của game

    public float dokho = 1;


    public static GameController instance;
    // public TextMeshProUGUI txtHero;
    void Awake()
    {
        instance = this;
        StartCoroutine(LoadData());
    }
    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(0.25f);
        dataPlayerController = DataPlayerController.instance;

        dataPlayerController.userGold = 1000;
        txtGold.text = dataPlayerController.userGold.ToString();
        dataPlayerController.userGem = 0;
        txtGem.text = dataPlayerController.userGem.ToString();
        dataPlayerController.userEnerge = 0;
        txtEnerge.text = dataPlayerController.userEnerge.ToString() + " / 5";

        userWaveStar = 0;
        txtWaveStar.text = userWaveStar.ToString();

        userWaveFinish = 0;
        txtWaveFinish.text = userWaveFinish.ToString();
    }

}
