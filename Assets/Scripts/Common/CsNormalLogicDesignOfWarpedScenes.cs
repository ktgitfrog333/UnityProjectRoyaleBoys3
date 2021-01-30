using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン遷移制御するクラス
/// </summary>
public class CsNormalLogicDesignOfWarpedScenes
{
    /// <summary>次のシーンへ渡す値</summary>
    private object _data = new object();

    /// <summary>
    /// 次のシーンへ遷移する
    /// </summary>
    /// <param name="sceneName">シーン名</param>
    public IEnumerator WarpScenesWithGameSystem(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            yield return new WaitForSeconds(CsNormalLevelDesignOfCommon.COOL_TIME);
            SceneManager.LoadScene(sceneName);
        }
    }

    /// <summary>
    /// 次のシーンへ値を渡して遷移する
    /// </summary>
    /// <param name="sceneName">シーン名</param>
    /// <param name="data">次のシーンへ渡す値</param>
    public IEnumerator WarpScenesWithGameSystem(string sceneName, object data)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            yield return new WaitForSeconds(CsNormalLevelDesignOfCommon.COOL_TIME);
            _data = data;
            SceneManager.sceneLoaded += GameSceneLoaded;
            SceneManager.LoadScene(sceneName);
        }
    }

    /// <summary>
    /// 次のシーンにあるオブジェクトへ値を渡す
    /// </summary>
    /// <param name="next"></param>
    /// <param name="mode"></param>
    private void GameSceneLoaded(Scene next, LoadSceneMode mode)
    {
        var g = GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_CANVASRESULT).GetComponent<ScResultUIAnimation>();
        g._csScoresBean = (CsScoresBean)_data;

        // シーン移動の度に実行されないように消す
        SceneManager.sceneLoaded -= GameSceneLoaded;
    }
}
