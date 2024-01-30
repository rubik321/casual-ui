using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Rarity
{
    Common = 0,
    Premium = 1,
    Rare = 2,
    Epic = 3,
    Legendary = 4,
    Mythical = 5
}
public enum WeaponType
{
    Sword = 0,
    Hat = 1,
    Ring = 2,
    Amor = 3,
    Banner = 4,
    Leg = 5


}
[Serializable]
public class GearData
{
    public int ID;
    public string Name;
    public string GetGold;
    public float BasicATK;
    public float CRITATK;
    public float ATKSPD;
    public float MOVSPS;
    public int Star;
    public Rarity Rarity;
    public int Level;
    public string Descreption;
    public WeaponType WeaponType;
}
public class DataController : MonoBehaviour
{
    public GearData[] gearData;
    public GearData[] EquipmentData;
    public static DataController Instance;

    void Awake()
    {
        Instance = this;
    }
}
