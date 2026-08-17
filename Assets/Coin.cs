using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private BoxCollider2D spawnArea;
    [SerializeField] private Transform player;
    [SerializeField] private float minimumDistance = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddScore();
            MoveToRandomPosition();
        }
    }

    private void MoveToRandomPosition()
    {
        Bounds bounds = spawnArea.bounds;

        Vector3 newPosition;

        do
        {
            float randomX = Random.Range(bounds.min.x, bounds.max.x);
            float randomY = Random.Range(bounds.min.y, bounds.max.y);

            newPosition = new Vector3(randomX, randomY, 0f);
        }
        while (Vector3.Distance(newPosition, player.position) < minimumDistance);

        transform.position = newPosition;
    }
}