using System.Collections;
using UnityEngine;

public class PipeSpawnScrypt : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 5f;
    public float heightOffset = 3f;

    void Start()
    {
        StartCoroutine(SpawnPipeRoutine());
    }

    IEnumerator SpawnPipeRoutine()
    {
        while (true)
        {
            SpawnPipe();
            yield return new WaitForSeconds(spawnTime);
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

