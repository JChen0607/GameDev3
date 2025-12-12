using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D RB;
    public float speed = 5;
    public float HP;                                                                                                                                                                               
    public float MaxHunger = 100;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;
    public int MaxHP = 10;
    private int currentHealth;
    private void Start()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    public void Damaged(float damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - RB.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        RB.rotation = angle;
    }
}
