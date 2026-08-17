using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject enemyObject;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Spawn()
    {
        GameObject enemy = Instantiate(enemyObject, transform.position, transform.rotation);
        EnemyController enemyController = enemy.GetComponent<EnemyController>();

        enemyController.health = 5;
        enemyController.speed = 4;
        enemyController.damage = 1;
    }
}
