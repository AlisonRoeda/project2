using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threatstat : MonoBehaviour {

    public int StartingHealth;
    int CurrentHealth;
    public GameObject[] spawns;

    // Use this for initialization
    void Start() {
        CurrentHealth = StartingHealth;
        spawns = GameObject.FindGameObjectsWithTag("Spawn");
    }
    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        if (CurrentHealth <= 0)
        {
            Death();
        }

    }
    void Death()
    {
        Vector3 RespawnLocation = spawns[Random.Range(0, 4)].transform.position;
        transform.position = RespawnLocation;
        CurrentHealth = StartingHealth;
    }

}
