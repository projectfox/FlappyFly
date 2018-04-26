using UnityEngine;

public class CoinCollector : MonoBehaviour {

    public int CoinCollectorSize = 5;
    private GameObject[] coin;

    void Start () {
		
	}
	
	
	void Update () {	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Destroy (gameObject);

    }
}
