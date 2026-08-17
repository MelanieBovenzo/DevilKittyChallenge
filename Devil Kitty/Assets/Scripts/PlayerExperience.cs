using Unity.VisualScripting;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    public int xp;
    [SerializeField] float XPSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("XP"))
        {
            collider.gameObject.GetComponent<XPController>().FollowPlayer(transform, XPSpeed);
        }
    }
}
