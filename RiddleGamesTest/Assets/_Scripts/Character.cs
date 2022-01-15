using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Character", order = 0)]
public class Character : ScriptableObject
{
    public string characterName;
    public int health;
    public int mana;
    public int whichMesh;
    public string specialAttack;
    public string battleRoar;

    public void BattleRoar()
    {
        Debug.Log(battleRoar);
    }
}
