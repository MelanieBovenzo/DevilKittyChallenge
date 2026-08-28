using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject enemyObject;
    [SerializeField] PlayerExperience xp;

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

        if (xp.level <= 3)
        {
            // SPRITE: NORMAL
            enemyController.health = 5 + xp.level;
            enemyController.speed = 4 + xp.level / 5;
            enemyController.damage = 1 + xp.level / 7;
        }
        else if (xp.level <= 9)
        {
            int random = Random.Range(0, 9);
            if (random <= Mathf.Floor(xp.level / 2))
            {
                // SPRITE: INIMIGO RAPIDO
                enemyController.health = 4 + xp.level;
                enemyController.speed = 6 + xp.level / 4;
                enemyController.damage = 0.8f + xp.level / 8;
            }
        }
        else
        {
            int random = Random.Range(0, 25);
            if (random <= Mathf.Floor(xp.level / 3))
            {
                // SPRITE: INIMIGO RAPIDO
                enemyController.health = 4 + xp.level;
                enemyController.speed = 6 + xp.level / 4;
                enemyController.damage = 2 + xp.level / 8;
            }
            else if (random > Mathf.Floor(xp.level / 2))
            {
                // SPRITE: NORMAL
                enemyController.health = 5 + xp.level;
                enemyController.speed = 4 + xp.level / 5;
                enemyController.damage = 1 + xp.level / 7;
            }
            else
            {
                // SPRITE: LENTO
                enemyController.health = 8 + xp.level * 3;
                enemyController.speed = 2 + xp.level / 5;
                enemyController.damage = 3 + xp.level / 7;
            }
        }
    }
}
