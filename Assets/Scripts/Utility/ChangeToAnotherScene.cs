using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToAnotherScene : MonoBehaviour
{
    [SerializeField] private string newSceneName;
    [SerializeField] private bool doChangeScene = false;

    // Update is called once per frame
    void Update()
    {
        if (doChangeScene) {
            SceneManager.LoadScene(newSceneName);
        }
    }
}
