using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour
{
    public Character character;

    private void Start()
    {
        gameObject.name = character.characterName;
        ChooseMesh();
    }

    private void Update()
    {
        BattleShout();
    }

    private void ChooseMesh()
    {
        switch (character.whichMesh)
        {
            case 0:
                transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                break;
            case 1:
                transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                break;
            case 2:
                transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
                break;
            default:
                Debug.LogWarning("Something wrong with mesh number!");
                break;
        }
    }

    private void BattleShout()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(character.name + "`s battle shout!");
            Debug.Log("Name: " + character.name + "\nHealth: " + character.health +
                      "Mana: " + character.mana + "\nBattle shout: " + character.battleRoar);
        }
    }
}
