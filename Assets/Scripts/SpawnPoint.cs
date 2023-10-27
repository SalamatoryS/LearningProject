using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _spawnEnemy;

    private void Start()
    {
        InvokeRepeating("Spawn", 5f, 5f);  
    }

    void Spawn()
    {
        Instantiate(_spawnEnemy,gameObject.transform.position, transform.rotation);
    }
}
