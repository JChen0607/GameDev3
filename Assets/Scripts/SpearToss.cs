using UnityEngine;

public class SpearToss : MonoBehaviour
{
    public Transform throwPoint;
    public GameObject spearPrefab;

    public float throwStrength = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Throw();
        }
    }
    void Throw()
    {
        GameObject spear = Instantiate(spearPrefab, throwPoint.position, throwPoint.rotation);
        Rigidbody2D rb = spear.GetComponent<Rigidbody2D>();
        rb.AddForce(throwPoint.up * throwStrength, ForceMode2D.Impulse);
    }
}
