using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    int _indexCurrentScene;

    private void Start()
    {
        _indexCurrentScene = _getCurrentBuildIndex();
    }

    public void BrickWall()
    {
        _indexCurrentScene = _getCurrentBuildIndex();
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(_indexCurrentScene);

    }

    public void PinBall()
    {
        _indexCurrentScene = _getCurrentBuildIndex();
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(_indexCurrentScene);

    }

    private int _getCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}