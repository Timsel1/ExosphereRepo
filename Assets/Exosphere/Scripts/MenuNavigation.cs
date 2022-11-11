using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void StartLevel1()
    {
        MMSceneLoadingManager.LoadScene("Exosphere1");
    }

    public void StartLevel2()
    {
        MMSceneLoadingManager.LoadScene("Exosphere");
    }

    public void StartLevel3()
    {
        MMSceneLoadingManager.LoadScene("ExosphereTestMap");
    }

    public void StartLevel4()
    {
        MMSceneLoadingManager.LoadScene("RandomlyGenerated");
    }

    public void GoToMainMenu()
    {
        MMSceneLoadingManager.LoadScene("MainMenu");
    }

    public void StartTutorial()
    {
        MMSceneLoadingManager.LoadScene("Tutorial");
    }

}
