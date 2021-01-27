using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScTimer : MonoBehaviour
{
    /// <summary>シーン遷移制御ロジック</summary>
    private CsNormalLogicDesignOfWarpedScenes _csNormalLogicDesignOfWarpedScenes;

    /// <summary>タイマー画像</summary>
    private Image _uiTimer;

    /// <summary>制限時間</summary>
    [SerializeField] private float _limitTime = 300.0f;
    /// <summary>スコア情報</summary>
    public CsScoresBean _csScoresBean;
    /// <summary>タイマーImageのfillAmount値</summary>
    private float _imageFillAmount;

    /// <summary>時間切れになった時に移動するシーン名</summary>
    [SerializeField] private string _warpSceneName = CsNormalLevelDesignOfCommon.SCENES_NAME_03_RESULT;

    // Start is called before the first frame update
    void Start()
    {
        _csNormalLogicDesignOfWarpedScenes = new CsNormalLogicDesignOfWarpedScenes();
        _csScoresBean = new CsScoresBean();
        _csScoresBean.limitTime = _limitTime;
        _imageFillAmount = CsNormalLevelDesignOfCommon.FLOAT_ZERO;

        _uiTimer = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _csScoresBean.countTime += Time.deltaTime;
        if ((_csScoresBean.countTime) < _csScoresBean.limitTime)
        {
            _csScoresBean.nowTime = _csScoresBean.limitTime - _csScoresBean.countTime;
            _imageFillAmount = 1.0f - (_csScoresBean.countTime / _csScoresBean.limitTime);
            _uiTimer.fillAmount = _imageFillAmount;
        }
        else
        {
            _csScoresBean.nowTime = CsNormalLevelDesignOfCommon.FLOAT_ZERO;
            _csNormalLogicDesignOfWarpedScenes.WarpScenesWithGameSystem(_warpSceneName, _csScoresBean);
        }
    }
}
