using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Character" , menuName = "Player" )]
public class Character : ScriptableObject
{
    public string name;
    public int speed;
    public int power;
    public int coordination;
    public int magic;
    public int agility;
    public int fitness;
    public GameObject playerCharacter;
}
