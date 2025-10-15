using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public float speed = 3;
    public float MaxHP = 15;
    public float HP;
    public float Damage = 2;
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

            //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //RB.rotation = angle;
        }
    }
    private void FixedUpdate()
    {
        if(Target)
        {
            RB.linearVelocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
    }
    public void TakingDamage (float damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Damaged(2);
        }
    }
}
