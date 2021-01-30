using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゴール制御するスクリプトクラス
/// </summary>
public class ScGoalSequence : MonoBehaviour
{
    /// <summary>位置情報</summary>
    Vector3 _position;
    /// <summary>浮遊移動コルーチン</summary>
    IEnumerator _moveFloatUp;
    /// <summary>シーン遷移制御ロジック</summary>
    private CsNormalLogicDesignOfWarpedScenes _csNormalLogicDesignOfWarpedScenes;

    /// <summary>決定を一度だけ受け付けるフラグ</summary>
    private bool _onceSubmitFlag;

    // Start is called before the first frame update
    void Start()
    {
        _csNormalLogicDesignOfWarpedScenes = new CsNormalLogicDesignOfWarpedScenes();
        _position = this.transform.position;
        _onceSubmitFlag = false;
        _moveFloatUp = MoveFloatUp();
        StartCoroutine(_moveFloatUp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_UNITYCHAN) && !_onceSubmitFlag)
        {
            _onceSubmitFlag = true;
            StopCoroutine(_moveFloatUp);
            var v = GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_IMTIMER01).GetComponent<ScTimer>();
            CsScoresBean bean = v._csScoresBean;
            StartCoroutine(_csNormalLogicDesignOfWarpedScenes.WarpScenesWithGameSystem(CsNormalLevelDesignOfCommon.SCENES_NAME_03_RESULT, bean));
            GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_IMFADE).GetComponent<ScOpenCloseSceneAnimation>().CloseScene();
        }
    }

    /// <summary>
    /// 現在位置からY方向へ移動して、元へ戻る
    /// <para/>浮遊しているような動きにする
    /// </summary>
    /// <returns></returns>
    private IEnumerator MoveFloatUp()
    {
        while (true)
        {
            this.transform.position = new Vector3(_position.x, Mathf.Sin(Time.time) * 2.0f + _position.y, _position.z);
            yield return null;
        }
    }
}
