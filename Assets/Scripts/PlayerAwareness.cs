using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public float speed = 3;
    public float MaxHP = 15;
    public float HP;
    public int damage = 2;
    Rigidbody2D RB;
    Transform Target;
    Vector2 moveDirection;

    private void Awake()
    {
        HP = MaxHP;
        RB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target)
        {
            Vector3 direction = (Target.position - transform.position).normalized;
            moveDirection = direction;
        }
    }
    private void FixedUpdate()
    {
        if(Target)
        {
            RB.linearVelocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
    }
    public void TakingDamage (int damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
  
}
