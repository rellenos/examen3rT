using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public Weapons weapons;
    public Armors armors;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player" && this.gameObject.tag == "Weapon")
        {
            Inventory.Instance.AddWeapon(weapons);
            Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Player" && this.gameObject.tag == "Armor")
        {
            Inventory.Instance.AddArmor(armors);
            Destroy(gameObject);
        }
    }
}
