using UnityEngine;

public class CollisionEffect : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem alertEffectPrefab;
    public float detectionRange = 20f;

    private bool hasTriggered = false;

    void Start()
    {
        player = GameObject.Find("JohnLemon");
    }

    void DetectPlayer()
    {
        // Avoid spawning the effect multiple times
        if (hasTriggered) return;

        hasTriggered = true;

        // Example trigger when player is found
        Vector3 spawnPosition = transform.position + new Vector3(0, 1.5f, 0); // slightly above enemy
        Instantiate(alertEffectPrefab, spawnPosition, Quaternion.identity, this.transform);
        alertEffectPrefab.Play();
        
        Debug.Log("Player found! Alert effect triggered!");
    }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         DetectPlayer();
    //     }
    // }

    void Update()
    {
        if (!hasTriggered && Vector2.Distance(player.transform.position, transform.position) < detectionRange)
        {
            DetectPlayer();
        }
    }
}
