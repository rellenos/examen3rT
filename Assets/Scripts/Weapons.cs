using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "items/weapons", fileName = "New weapon")]
public class Weapons : ScriptableObject
{
    public string weaponName;
    public string weaponDamage;
    public Sprite weaponSprite;
}
