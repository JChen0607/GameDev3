using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Animals : MonoBehaviour
{
    public float maxHealth = 5;
    public float speed = 7;
    public float Health;
    Vector2 moveDirection;
    Rigidbody2D RigidB;
    public float deadZone = -20;

    //Loottable
    [Header("Loot")]
    public List<LootItem> lootTable = new List<LootItem>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = maxHealth;
        RigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
 
    public void TakeDamage(float damageAmount)
    {
        Health -= damageAmount;

        if (Health <= 0)
        {
            foreach (LootItem lootItem in lootTable)
            {
                if(Random.Range(0f,100f) <= lootItem.dropChance)
                {
                    InstantiateLoot(lootItem.itemPrefab);
                    break;
                }
               
            }
            Destroy(gameObject);
        }
    }
    void InstantiateLoot (GameObject loot)
    {
        if (loot)
        {
            GameObject droppedLoot = Instantiate(loot, transform.position, Quaternion.identity);

            droppedLoot.GetComponent<SpriteRenderer>();
        }
    }


}
