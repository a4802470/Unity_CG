
using UnityEngine;
using UnityEngine.SceneManagement;
public class menumanagers : MonoBehaviour
{
    public void Startgmae()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void Quitgmae()
    {
        Application.Quit();
    }





}
