using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    [SerializeField]
    private GameObject chicken_Prefab, cannibal_Prefab;

    public Transform[] cannibal_SpawnPoints, chicken_SpawnPoints;

    [SerializeField]
    private int cannibal_Count, chicken_Count;

    private int initial_CountCannibal, initial_CountChicken;

    public float waitBeforeSpawnEnemiesTime = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
    }
    void Start()
    {
        initial_CountCannibal = cannibal_Count;
        initial_CountChicken = chicken_Count;

        SpawnEnemies();

        StartCoroutine("CheckToSpawnEnemies");
    }


    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void SpawnEnemies()
    {
        SpawnCannibals();
        SpawnChickens();
    }

    void SpawnCannibals()
    {
        int index = 0;

        for(int i=0; i < cannibal_Count; i++)
        {

            if(index >= cannibal_SpawnPoints.Length)
            {
                index = 0;
            }
            Instantiate(cannibal_Prefab, cannibal_SpawnPoints[index].position, Quaternion.identity);
            index++;
        }
        cannibal_Count = 0;
    }

    void SpawnChickens()
    {
        int index = 0;

        for (int i = 0; i < chicken_Count; i++)
        {

            if (index >= chicken_SpawnPoints.Length)
            {
                index = 0;
            }
            Instantiate(chicken_Prefab, chicken_SpawnPoints[index].position, Quaternion.identity);
            index++;
        }
        chicken_Count = 0;
    }

    IEnumerator CheckToSpawnEnemies()
    {
        yield return new WaitForSeconds(waitBeforeSpawnEnemiesTime);

        SpawnCannibals();
        SpawnChickens();
        StartCoroutine("CheckToSpawnEnemies");
    }

    public void EnemyDied(bool cannibal)
    {
        if (cannibal)
        {
            cannibal_Count++;
            if(cannibal_Count > initial_CountCannibal)
            {
                cannibal_Count = initial_CountCannibal;
            }
        }
        else
        {
            chicken_Count++;
            if (chicken_Count > initial_CountChicken)
            {
                chicken_Count = initial_CountChicken;
            }
        }
    }

    public void StopSpawning()
    {
        StopCoroutine("CheckToSpawnEnemies");
    }






}//class
