using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHP = 10;
    private int currentHealth;

    public HealthUI healthUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = MaxHP;
        healthUI.SetMaxHeart(MaxHP);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerAwareness enemy = collision.GetComponent<PlayerAwareness>();
        if (enemy)
        {
            Damaged(enemy.damage);
        }
    }
    public void Damaged(int damageAmount)
    {
        currentHealth -= damageAmount;
        healthUI.UpdateHearts(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
