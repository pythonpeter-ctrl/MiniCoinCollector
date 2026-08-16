using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            gameManager.AddScore();
            Destroy(gameObject);
        }
        
    }
}