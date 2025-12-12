using System;
using UnityEngine;


public class Fur : MonoBehaviour, Iitem 
{
    public static event Action<int> OnFurCollect;
    public int worth = 20;
    public void Collect()
    {
        OnFurCollect.Invoke(worth);
        Destroy(gameObject);
    }
}
