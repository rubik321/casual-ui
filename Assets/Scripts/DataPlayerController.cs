using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlayerController : MonoBehaviour
{
    public Hero hero;
    public Boss boss;
    public static DataPlayerController instance;
    void Awake() 
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        LoadInfoHero();
    }
    void LoadInfoHero ()
    {
        hero.Atk = 10;
        hero.Def = 10;
        hero.HP = 10;
        hero.Crit = 10;
        hero.Critatk = 10;
        hero.Decisive = 10;
        boss.HPBoss = 50;
    }
    
}
[Serializable]
public class Boss 
{
    public int HPBoss;
    public int GoldBoss;
}
// [Serializable]
// public class InfoBoss
// {
//     public int ID;
//     public int Atk;
//     public int Def ;
//     public int HP ;
//     public int Crit ;
//     public int Critatk ;
//     public int Decisive ;

// }
[Serializable]
public class Hero
{
    public int ID;
    public int Atk;
    public int Def ;
    public int HP ;
    public int Crit ;
    public int Critatk ;
    public int Decisive ;
}
