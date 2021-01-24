using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// UIボタンをクリックした時にタイトル画面へ遷移するスクリプトクラス
/// </summary>
public class ScReturnTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene(CsNormalLevelDesignOfCommon.SCENES_NAME_01_TITLE);
    }
}
