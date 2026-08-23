using UnityEngine;
using UnityEngine.UIElements;

public class AimController : MonoBehaviour
{
    [SerializeField] Transform aimTransform;
    [SerializeField] Transform aim2Transform;
    [SerializeField] Transform aim3Transform;

    public Transform center;

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
        Vector3 position = center.position;
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
    void FixedUpdate()
    {
        if (FindClosestEnemy() != null)
        {
            Vector3 closestPosition = FindClosestEnemy().transform.position;

            Vector3 diff = closestPosition - center.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            aimTransform.rotation = Quaternion.Euler(0f, 0f, rot_z);
            aim2Transform.rotation = Quaternion.Euler(0f, 0f, rot_z + 30);
            aim3Transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 30);
        }
    }
}
