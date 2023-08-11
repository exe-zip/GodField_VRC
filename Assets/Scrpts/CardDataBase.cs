using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="MyScriptable/Create CardData")]
public class CardDataBase : ScriptableObject
{
    //���ʍ���
    public string name;
    public string description;  
    public int type;            
    public int element;
    public Texture tex;

    //��
    public int price;
    public int damage;
    public int heal_hp;
    public int heal_mp;
    public int cost;
}
