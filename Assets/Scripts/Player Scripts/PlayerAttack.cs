using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private WeaponManager weapon_Manager;
    
    public float firerate;
    public float damage = 20f;
    private Camera mainCam;

    void Awake()
    {
        weapon_Manager = GetComponent<WeaponManager>();

        mainCam = Camera.main;
    }

    void Start()
    {
        
    }

    void Update () {
        WeaponShoot();

    }

    void WeaponShoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("Button clicked");
            if(weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.BULLET)
            {
                weapon_Manager.GetCurrentSelectedWeapon().ShootAnim();

                BulletFired();
            }
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 30;
            Debug.DrawRay(transform.position, forward, Color.green);
        }

    }
    void BulletFired()
    {
        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit)) 
        { 
                print("Hit: " + hit.transform.gameObject.name);
            
            if (hit.transform.tag == Tags.ENEMY_TAG)
            {
                hit.transform.GetComponent<HealthScript>().ApplyDamage(damage);
            }
        }
    }
}
