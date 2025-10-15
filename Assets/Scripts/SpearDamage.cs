using Unity.VisualScripting;
using UnityEngine;

public class SpearDamage : MonoBehaviour
{
    public float damage = 2;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        if (other.gameObject.TryGetComponent<PlayerAwareness>(out PlayerAwareness enemy))
        {
            enemy.TakingDamage(2);
        }

        if (other.gameObject.TryGetComponent<Animals>(out Animals animals))
        {
            animals.TakeDamage(2);
        }
    }
}
