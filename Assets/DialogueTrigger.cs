using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool hasTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;
            Debug.Log("Good Job!");

            // If you later want UI dialogue, you can call it here
            // DialogueManager.Show("Good Job!");
        }
    }
}

