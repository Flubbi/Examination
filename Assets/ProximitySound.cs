using UnityEngine;

public class ProximitySound : MonoBehaviour
{
    public Transform player;
    public float triggerDistance = 5f;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(player.position, transform.position);

        if (distance < triggerDistance)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}

