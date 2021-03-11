using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthScript : MonoBehaviour
{

    private NavMeshAgent navAgent;
    public float health = 100f;
    public bool is_Player, is_Chicken, is_Cannibal;
    private bool is_Dead;
    private PlayerStats playerStats;


    void Awake()
    {

        if (is_Player)
        {
            playerStats = GetComponent<PlayerStats>();
        }
    }

    public void ApplyDamage(float damage)
    {
        if (is_Dead)
            return;

        health -= damage;

        if (is_Player)
        {
            playerStats.Display_HealthStats(health);
        }

        if(health <= 0)
        {
            PlayerDied();
            is_Dead = true;
        }
    }
    void PlayerDied()
    {
        if (is_Cannibal)
        {
            GetComponent<Animator>().enabled = false;
            GetComponent<BoxCollider>().isTrigger = false;
            GetComponent<Rigidbody>().AddTorque(-transform.forward * 50f);

            navAgent.enabled = false;
            StartCoroutine(DeathSound());
            //spawn more enemies
            EnemyManager.instance.EnemyDied(true);
        }
        if (is_Chicken)
        {
            navAgent.velocity = Vector3.zero;
            navAgent.isStopped = true;
            StartCoroutine(DeathSound());
            EnemyManager.instance.EnemyDied(false);
        }
        if (is_Player)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(Tags.ENEMY_TAG);
            EnemyManager.instance.StopSpawning();
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PlayerAttack>().enabled = false;
            GetComponent<WeaponManager>().GetCurrentSelectedWeapon().gameObject.SetActive(false);
        }
        if(tag == Tags.PLAYER_TAG)
        {
            Invoke("RestartGame", 3f);
        }
        else
        {
            Invoke("TurnOffGameObject", 3f);
        }
    }//PlayerDied
    void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }

    IEnumerator DeathSound()
    {
        yield return new WaitForSeconds(0.3f);
    }
}//class
