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
        yield return new WaitForSeconds(Mathf.Pow(xp.level, -0.4f));

        spawnTargets[Random.Range(0, 6)].Spawn();

        StartCoroutine(spawnInRandomPos());
    }
}
