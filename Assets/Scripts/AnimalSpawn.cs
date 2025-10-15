using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject animalPrefab;

    [SerializeField]
    private float minSpawnTimer;

    [SerializeField]
    private float maxSpawnTimer;

    private float timeTilSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SetTimeTilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeTilSpawn -= Time.deltaTime;

        if (timeTilSpawn <= 0)
        {
            Instantiate(animalPrefab, transform.position, Quaternion.identity);
            SetTimeTilSpawn();
        }
    }

    private void SetTimeTilSpawn()
    {
        timeTilSpawn = Random.Range(minSpawnTimer, maxSpawnTimer);

    }
}
