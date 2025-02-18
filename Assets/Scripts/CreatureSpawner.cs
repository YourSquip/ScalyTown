using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _creaturePrefab;
    Stack<GameObject> _creatures;
    [SerializeField] Stats _stats;
    
    private float _timeUntilSpawn;
    [SerializeField] private float _minimumSpawnTime;
    [SerializeField] private float _maximumSpawnTime;
    void Start()
    {
        SetTimeUntilSpawn();
        //_stats.spawned = 0;
        _creatures = new Stack<GameObject>();
    }

   
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;
        if(_timeUntilSpawn <= 0)
        {
            if (_stats.population > _stats.spawned)
            {
                
                  GameObject obj = Instantiate(_creaturePrefab, transform.position, Quaternion.identity);
                  _creatures.Push(obj);
                  //Debug.Log("Villagers are coming");
                  SetTimeUntilSpawn();
                  _stats.spawned++;
            }
            if (_stats.population < _stats.spawned)
            {
                    //GameObject obj = Instantiate(_creaturePrefab, transform.position, Quaternion.identity);
                    // _creatures.Add(obj);
                 //Debug.Log("Villagers are leaving");
                 deleteCreature();
                _stats.spawned--;
            }

            
           
        }
        
    }

    void deleteCreature()
    {
        if(_creatures.Count!=0) Destroy(_creatures.Pop());
    }

    void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = UnityEngine.Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
