using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : ScriptableObject
{
    IEnumerator LoadLevel()
    {
        SceneManager.LoadScene("Bugwar2D", LoadSceneMode.Additive);
        yield return null;
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Bugwar2D"));
    }

}

