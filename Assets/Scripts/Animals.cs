using UnityEngine;

public class Animals : MonoBehaviour
{
    public float maxHealth = 5;
    public float speed = 7;
    public float Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damageAmount)
    {
        Health -= damageAmount;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
