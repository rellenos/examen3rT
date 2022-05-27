using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "items/armors", fileName = "New armor")]
public class Armors : ScriptableObject
{
    public string armorName;
    public string armorDurability;
    public Sprite armorSprite;
}

