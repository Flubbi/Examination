using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    public void GoToUI()
    {
        SceneManager.LoadScene("UI");
    }

    public void GoToExamination()
    {
        SceneManager.LoadScene("Examination");
    }
}

