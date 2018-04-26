using UnityEngine;

public class CoinPool : MonoBehaviour {

    public int coinsPoolSize = 5;
    public GameObject coinsPrefab;
    public float spawnRate = 4f;
    public float coinMin = -1f;
    public float coinMax = 3.5f;


    private GameObject[] coins;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 0;
    private int currentCoin = 0;
	
	void Start () {
        coins = new GameObject[coinsPoolSize];
        for (int i = 0; i < coinsPoolSize; i++) {
            coins[i] = Instantiate(coinsPrefab, objectPoolPosition, Quaternion.identity);
            coins[i].transform.SetParent(transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;

        if ( GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) {

            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range (coinMin, coinMax);
            coins[currentCoin].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentCoin++;
            if (currentCoin >= coinsPoolSize) {

                currentCoin = 0;
            }
        }
	}
}
