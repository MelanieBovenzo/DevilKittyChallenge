using System.Collections;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    [SerializeField] PlayerExperience xp;

    [SerializeField] private SpawnerController[] spawnTargets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnInRandomPos());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnInRandomPos()
    {
        yield return new WaitForSeconds(1);

        spawnTargets[Random.Range(0, 5)].Spawn();

        StartCoroutine(spawnInRandomPos());
    }
}
