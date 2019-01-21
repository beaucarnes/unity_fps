using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    [SerializeField]
    private WeaponHandler[] weapons;

    private int current_Weapon_Index;

	// Use this for initialization
	void Start () {
        current_Weapon_Index = 0;
        weapons[current_Weapon_Index].gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            TurnOnSelectedWeapon(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            TurnOnSelectedWeapon(1);
        }
    
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            TurnOnSelectedWeapon(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            TurnOnSelectedWeapon(3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            TurnOnSelectedWeapon(4);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            TurnOnSelectedWeapon(5);
        }

    } // update

    void TurnOnSelectedWeapon(int weaponIndex) {

        if (current_Weapon_Index == weaponIndex)
            return;

        // turn of the current weapon
        weapons[current_Weapon_Index].gameObject.SetActive(false);

        // turn on the selected weapon
        weapons[weaponIndex].gameObject.SetActive(true);

        // store the current selected weapon index
        current_Weapon_Index = weaponIndex;

    }

    public WeaponHandler GetCurrentSelectedWeapon() {
        return weapons[current_Weapon_Index];
    }

} // class

































