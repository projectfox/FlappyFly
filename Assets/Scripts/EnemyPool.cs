using UnityEngine;

public class EnemyPool : MonoBehaviour {
    public int EnemysPoolSize = 2;
    public GameObject EnemyPrefab;
    public float spawnRate = 4f;
    public float EnemyMin = -1f;
    public float EnemyMax = 3.5f;
  


    private GameObject[] Enemy;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10;
    private int currentEnemy = 0;

    void Start()
    {
        Enemy = new GameObject[EnemysPoolSize];
        for (int i = 0; i < EnemysPoolSize; i++)
        {
            Enemy[i] = Instantiate(EnemyPrefab, objectPoolPosition, Quaternion.identity);
            Enemy[i].transform.SetParent(transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {

            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(EnemyMin, EnemyMax);
            Enemy[currentEnemy].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentEnemy++;
            if (currentEnemy >= EnemysPoolSize)
            {

                currentEnemy = 0;
            }
        }
    }
}
