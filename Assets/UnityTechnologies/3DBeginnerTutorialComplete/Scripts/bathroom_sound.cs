using UnityEngine;

public class bathroom_sound : MonoBehaviour
{
    
    public AudioSource sound_effect;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            if (sound_effect != null)
            {
                sound_effect.Play();
                hasTriggered = true;
            }
        }
    }
}
