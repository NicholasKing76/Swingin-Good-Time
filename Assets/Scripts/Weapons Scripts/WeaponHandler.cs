using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponAim
{
    NONE,
    SELF_AIM,
    AIM
}

public enum WeaponFireType
{
    SINGLE,
    MULTIPLE
}

public enum WeaponBulletType
{
    BULLET,
    NONE
}
public class WeaponHandler : MonoBehaviour
{
    private Animator anim;
    public WeaponAim weapon_aim;

    [SerializeField]
    private GameObject muzzleFlash;

    [SerializeField]
    private AudioSource shootSound, reload_Sound;

    public WeaponFireType fireType;
    public WeaponBulletType bulletType;
    public GameObject attackPoint;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void ShootAnim()
    {
        anim.SetTrigger(AnimTags.SHOOT_TRIGGER);
    }

    public void Aim(bool canAim)
    {
        anim.SetBool(AnimTags.AIM, canAim);
    }

    void Turn_On_MuzzleFlash()
    {
        muzzleFlash.SetActive(true);
    }
    void Turn_Off_MuzzleFlash()
    {
        muzzleFlash.SetActive(false);
    }

    void PlayShotSound()
    {
        shootSound.Play();
    }

    void PlayReloadSound()
    {
        reload_Sound.Play();
    }

    void TurnOnAttackPoint()
    {
        attackPoint.SetActive(true);
    }
    void TurnOffAttackPoint()
    {
        if (attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
    }
}
