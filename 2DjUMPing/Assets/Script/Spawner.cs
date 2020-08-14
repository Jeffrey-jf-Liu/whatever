using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMove_Easy[] enemies;
    [SerializeField] private float spawnTimeDelay, startSpawnDelay;
    public bool completed;
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startSpawnDelay);

        for (int i = 0; i < enemies.Length; i++)
        {
            EnemyMove_Easy enemyInstance = Instantiate(enemies[i], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTimeDelay);
        }
    }
}
