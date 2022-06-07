using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 20;
        Application.runInBackground = false;
        Application.backgroundLoadingPriority = ThreadPriority.Low;
    }
    public void NameSelect()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
