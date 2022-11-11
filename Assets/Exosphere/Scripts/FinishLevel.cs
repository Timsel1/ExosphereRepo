using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] string nextSceneName = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MMSceneLoadingManager.LoadScene(nextSceneName);
    }
}
