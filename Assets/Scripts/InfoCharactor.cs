using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoCharactor : MonoBehaviour
{
    public Slider LvCharactor;
    public TextMeshProUGUI textLvCharactor;

    public Hero InfoLevel;

    int LvHero;

    GameController gameController;
    DataPlayerController dataPlayerController;

    void Awake()
    {

        StartCoroutine(LoadData());
    }
    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(0.25f);
        gameController = GameController.instance;
        dataPlayerController = DataPlayerController.instance;

        InfoLevel.Level = dataPlayerController.hero.Level;


        LvHero = dataPlayerController.boss.HPBoss;
        // HPboss.value = LvHero;
        // textHpBoss.text = LvHero.ToString() + "/" + dataPlayerController.boss.HPBoss.ToString();
    }
}
