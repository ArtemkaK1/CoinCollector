using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            scoreManager.AddScore(1);
            Destroy(other.gameObject);
        }
    }
}
