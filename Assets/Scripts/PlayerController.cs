using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int Atk = 10;
    public int Def = 5;
    public int HP = 100;
    public int Crit = 5;
    public int Critatk = 0;
    public int Decisive = 0;
    void Start()
    {

    }
    
}
public class Boss 
{
    public int HPBoss;
    public int GoldBoss;

}

public class Hero
{
    public int HeroAtk;
    public double HeroCrit;
    public double HeroCritDame;
    public int HeroGold;
}
