using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void stage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void stage5()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void homes()
    {
        SceneManager.LoadScene("MainMenus");
    }
    public void quittt()
    {
        Application.Quit();
    }
}
