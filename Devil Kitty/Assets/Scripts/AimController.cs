using UnityEngine;
using UnityEngine.UIElements;

public class AimController : MonoBehaviour
{
    [SerializeField] Transform aimTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] enemyList;
        enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject enemy in enemyList)
        {
            Vector3 diff = enemy.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = enemy;
                distance = curDistance;
            }
        }
        return closest;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 closestPosition = FindClosestEnemy().transform.position;

        Vector3 diff = closestPosition - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        aimTransform.rotation = Quaternion.Euler(0f, 0f, rot_z);
    }
}
