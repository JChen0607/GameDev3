using UnityEngine;

public class Meat : MonoBehaviour, Iitem
{
    public void Collect()
    {
        Destroy(gameObject);
    }

    
}
