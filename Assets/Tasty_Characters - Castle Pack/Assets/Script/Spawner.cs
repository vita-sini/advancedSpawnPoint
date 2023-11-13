using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _target;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        var waitForSeconds = new WaitForSeconds(_timeBetweenSpawn);

        while (enabled)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            Enemy enemy = Instantiate(_enemy, _spawnPoints[spawnPointNumber].transform.position, Quaternion.identity);

            enemy.SetDirection(_target.transform);

            yield return waitForSeconds;
        }
    }
}
