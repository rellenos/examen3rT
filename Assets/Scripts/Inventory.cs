using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public Weapons[] weapons;
    public TextMeshProUGUI[] weaponName;
    public TextMeshProUGUI[] weaponDamage;
    public Image[] weaponSprite;

    public Armors[] armors;
    public TextMeshProUGUI[] armorName;
    public TextMeshProUGUI[] armorDurability;
    public Image[] armorSprite;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddWeapon(Weapons item)
    {
        for(int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] == null)
            {
                weapons[i] = item;
                weaponName[i].text = item.weaponName;
                weaponDamage[i].text = item.weaponDamage;
                weaponSprite[i].sprite = item.weaponSprite;
                Debug.Log("armas");
            
                return;
            }
        } 
    }

    public void AddArmor(Armors item)
    {
        for(int i = 0; i < armors.Length; i++)
        {
            if (armors[i] == null)
            {
                armors[i] = item;
                armorName[i].text = item.armorName;
                armorDurability[i].text = item.armorDurability;
                armorSprite[i].sprite = item.armorSprite;
                Debug.Log("armaduras");
            
                return;
            }
        } 
    }
}
