using UnityEngine;

using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("TheHunter");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
