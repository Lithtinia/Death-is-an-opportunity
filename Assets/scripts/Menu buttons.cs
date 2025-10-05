using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubuttons : MonoBehaviour
{
    public string STL;

    public GameObject PM;

    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PM.SetActive(true);
        }
    }
    
    public void NextScene()
    {
        SceneManager.LoadScene(STL);
    }

    public void quitgam()
    {
        Application.Quit();
        /// for debugging purposes 
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void continuegame()
    {
        PM.SetActive(false);
    }
}
