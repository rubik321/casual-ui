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


    private double userEnerge;
    private double userGold;
    private double userGem;

    private double userWaveStar;
    private double userWaveFinish;
    public BossItem bossItem;

    float cusHPBoss;

    // public TextMeshProUGUI txtHero;





    void Start()
    {
        userGold = 1000;
        txtGold.text = userGold.ToString();
        userGem = 0;
        txtGem.text = userGem.ToString();
        userEnerge = 0/5;
        txtEnerge.text = userEnerge.ToString();

        userWaveStar = 0;
        txtWaveStar.text = userWaveStar.ToString();

        userWaveFinish = 0;
        txtWaveFinish.text = userWaveFinish.ToString();

        cusHPBoss = DataPlayerController.instance.boss.HPBoss;
        bossItem.HPboss.value = cusHPBoss;
        bossItem.textHpBoss.text = cusHPBoss.ToString() + "/" + DataPlayerController.instance.boss.HPBoss.ToString();
    }

    public void Attack()
    {
        
        
        if(cusHPBoss > 0)
        {
            cusHPBoss = cusHPBoss - DataPlayerController.instance.hero.Atk;
            bossItem.HPboss.value = cusHPBoss/DataPlayerController.instance.boss.HPBoss;
            bossItem.textHpBoss.text = cusHPBoss.ToString() + "/" + DataPlayerController.instance.boss.HPBoss.ToString();
        }
        else
        {
            userGold = userGold + 100;
            txtGold.text = userGold.ToString();

            userWaveFinish = userWaveFinish + 1;
            txtWaveFinish.text = userWaveFinish.ToString();

            
            ResetBoss();
        }
    }

    public void ResetBoss()
    {

        DataPlayerController.instance.boss.HPBoss += 10;
        // bossItem.HPboss.value = DataPlayerController.instance.boss.HPBoss/DataPlayerController.instance.boss.HPBoss ;
        // bossItem.HPboss.value = cusHPBoss/DataPlayerController.instance.boss.HPBoss;
        cusHPBoss = DataPlayerController.instance.boss.HPBoss;
        bossItem.HPboss.value = cusHPBoss;
        bossItem.textHpBoss.text = cusHPBoss.ToString() + "/" + DataPlayerController.instance.boss.HPBoss.ToString();
       
    }



   
}
