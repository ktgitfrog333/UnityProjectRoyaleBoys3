using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UIボタンをクリックした時にタイトル画面へ遷移するスクリプトクラス
/// </summary>
public class ScReturnTitle : MonoBehaviour
{
    /// <summary>シーン制御ロジック</summary>
    private CsNormalLogicDesignOfWarpedScenes _csNormalLogicDesignOfWarpedScenes;

    /// <summary>遷移先のシーン名</summary>
    [SerializeField] private string _loadScenes = CsNormalLevelDesignOfCommon.SCENES_NAME_01_TITLE;
    /// <summary>決定を一度だけ受け付けるフラグ</summary>
    private bool _onceSubmitFlag;
    /// <summary>決定が押下された時のSE</summary>
    [SerializeField] private AudioSource _seSubmited;

    // Start is called before the first frame update
    void Start()
    {
        _csNormalLogicDesignOfWarpedScenes = new CsNormalLogicDesignOfWarpedScenes();
        _onceSubmitFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (!_onceSubmitFlag)
        {
            _onceSubmitFlag = true;
            StartCoroutine(_csNormalLogicDesignOfWarpedScenes.WarpScenesWithGameSystem(_loadScenes));
            GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_IMFADE).GetComponent<ScOpenCloseSceneAnimation>().CloseScene();
            _seSubmited.Play();
        }
    }
}
