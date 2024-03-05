using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class BossItem : MonoBehaviour
{
    public Slider HPboss;
    public TextMeshProUGUI textHpBoss;
    public Image imageBoss;
    public Boss infoBoss;
    float cusHPBoss;

    float maxHpBoss;
    GameController gameController;
    DataPlayerController dataPlayerController;

    int TimeAtk = 0;

    float tmpTime;


    void Start()
    {

        LoadData();
    }

    private void Update()
    {
        {
            tmpTime += Time.deltaTime;
            //Debug.Log(Time.deltaTime);
            if (Mathf.FloorToInt(tmpTime) > TimeAtk) // Hàm đổi làm tròn time
            {
                Attack();
                TimeAtk += 1;
            }


        }

    }

    void LoadData()
    {

        gameController = GameController.instance;
        dataPlayerController = DataPlayerController.instance;

        infoBoss.HPBoss = dataPlayerController.boss.HPBoss;
        infoBoss.GoldBoss = dataPlayerController.boss.GoldBoss;

        cusHPBoss = 50 + GameController.instance.Level * 10 * GameController.instance.dokho;
        maxHpBoss = cusHPBoss;
        HPboss.value = cusHPBoss / maxHpBoss;
        textHpBoss.text = cusHPBoss.ToString() + "/" + maxHpBoss.ToString();


    }
    void SwapImageBoss(Sprite spriteTarget)
    {
        imageBoss.sprite = spriteTarget;

    }
    public void Attack()
    {

        cusHPBoss = cusHPBoss - dataPlayerController.hero.Atk;
        HPboss.value = cusHPBoss / maxHpBoss;
        textHpBoss.text = cusHPBoss.ToString() + "/" + maxHpBoss.ToString();

        if (cusHPBoss <= 0)
        {
            BossDie();
        }
    }

    void BossDie()
    {
        dataPlayerController.userGold = dataPlayerController.userGold + 100;
        gameController.txtGold.text = dataPlayerController.userGold.ToString();

        gameController.userWaveFinish = gameController.userWaveFinish + 1;
        gameController.txtWaveFinish.text = gameController.userWaveFinish.ToString();

        // ham doi image nhan vat roondom

        GameController.instance.Level = GameController.instance.Level + 1;

        if (GameController.instance.Level % 10 == 0)
        {
            GameController.instance.dokho = GameController.instance.dokho + 0.5f;

        }

        ResetBoss();
    }
    public void ResetBoss()
    {
        // dataPlayerController.boss.HPBoss += 10;
        // // bossItem.HPboss.value = dataPlayerController.boss.HPBoss/dataPlayerController.boss.HPBoss ;
        // // bossItem.HPboss.value = cusHPBoss/dataPlayerController.boss.HPBoss;
        // cusHPBoss = dataPlayerController.boss.HPBoss;
        // HPboss.value = cusHPBoss;
        // textHpBoss.text = cusHPBoss.ToString() + "/" + dataPlayerController.boss.HPBoss.ToString();
        Sprite spriteTarget = dataPlayerController.lsSpriteIconBoss[Random.Range(0, dataPlayerController.lsSpriteIconBoss.Count - 1)];
        SwapImageBoss(spriteTarget);
        LoadData();

        //textHpBoss.text = calP().ToString();

    }


    int calP()
    {
        int att = 10;
        int HP = 30;

        int cHP = HP - att;

        return cHP;
    }
}
