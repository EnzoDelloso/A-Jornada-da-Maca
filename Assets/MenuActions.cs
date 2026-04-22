using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuActions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void IniciaJogo()
    {
        Time.timeScale = 1f;
        GameController.Init();
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
}
