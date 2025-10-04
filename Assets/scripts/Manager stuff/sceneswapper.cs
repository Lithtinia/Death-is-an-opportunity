using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneswapper : MonoBehaviour
{
    public string STLGood;
    public string STLBad;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void goodend()
    {
        SceneManager.LoadScene(STLGood);
    }
    
    public void badend()
    {
        SceneManager.LoadScene(STLBad);
    }
}
