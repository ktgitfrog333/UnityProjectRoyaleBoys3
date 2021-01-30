using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScImageSwitch : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /// <summary>遷移先のシーン名</summary>
    [SerializeField] private string _loadScenes = CsNormalLevelDesignOfCommon.SCENES_NAME_01_TITLE;

    /// <summary>UI表示制御クラス</summary>
    private CsNormalLogicDesignOfUIVisualController _csNormalLogicDesignOfUIVisualController;
    /// <summary>シーン制御ロジック</summary>
    private CsNormalLogicDesignOfWarpedScenes _csNormalLogicDesignOfWarpedScenes;

    /// <summary>位置情報を一時管理</summary>
    private CsRectTransformBean _csRectTransformBean;
    /// <summary>マスク情報を一時管理</summary>
    private CsRectMask2DBean _csRectMask2DBean;
    /// <summary>位置情報とマスク情報を一時管理</summary>
    private IDictionary<int, object> _swithSelectedVitual;
    /// <summary>決定を一度だけ受け付けるフラグ</summary>
    private bool _onceSubmitFlag;

    // Start is called before the first frame update
    void Start()
    {
        _csRectTransformBean = new CsRectTransformBean(this.gameObject.transform as RectTransform);
        _csRectMask2DBean = new CsRectMask2DBean(this.gameObject.GetComponent<RectMask2D>());
        _csNormalLogicDesignOfUIVisualController = new CsNormalLogicDesignOfUIVisualController();
        _csNormalLogicDesignOfWarpedScenes = new CsNormalLogicDesignOfWarpedScenes();
        _onceSubmitFlag = false;
        _swithSelectedVitual = new Dictionary<int, object>();
        _swithSelectedVitual = _csNormalLogicDesignOfUIVisualController.SwithSelectedVitual(_csRectTransformBean, _csRectMask2DBean, (int) EnumSwitchStaus.UnSelected);
        UpdateUIVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        // コントローラーの十字キー入力検知
        if (0 < Input.GetAxis(CsNormalLevelDesignOfCommon.INPUT_MANAGER_AXIS_HORIZONTAL3))
        {
            if (!_csNormalLogicDesignOfUIVisualController._switchStatus)
            {
                CsRectTransformBean transform = new CsRectTransformBean();
                CsRectMask2DBean mask2d = new CsRectMask2DBean();
                foreach (KeyValuePair<int, object> d in _swithSelectedVitual)
                {
                    if ((int)EnumUIBeanKeys.RectTransformBean == d.Key)
                    {
                        transform = (CsRectTransformBean)d.Value;
                    }
                    else if ((int)EnumUIBeanKeys.RectMask2DBean == d.Key)
                    {
                        mask2d = (CsRectMask2DBean)d.Value;
                    }
                }

                _swithSelectedVitual = _csNormalLogicDesignOfUIVisualController.SwithSelectedVitual(transform, mask2d, (int)EnumSwitchStaus.Selected);
                UpdateUIVisuals();
            }
        }

        // リターンもしくはコントローラーの決定ボタンが押される
        if (Input.GetButtonDown(CsNormalLevelDesignOfCommon.INPUT_MANAGER_BUTTON_SUBMIT))
        {
            if (_csNormalLogicDesignOfUIVisualController._switchStatus && !_onceSubmitFlag)
            {
                _onceSubmitFlag = true;
                StartCoroutine(_csNormalLogicDesignOfWarpedScenes.WarpScenesWithGameSystem(_loadScenes));
                GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_IMFADE).GetComponent<ScOpenCloseSceneAnimation>().CloseScene();
            }
        }
    }

    /// <summary>
    /// マウスポインタが触れた時
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!_csNormalLogicDesignOfUIVisualController._switchStatus)
        {
            CsRectTransformBean transform = new CsRectTransformBean();
            CsRectMask2DBean mask2d = new CsRectMask2DBean();
            foreach (KeyValuePair<int, object> d in _swithSelectedVitual)
            {
                if ((int)EnumUIBeanKeys.RectTransformBean == d.Key)
                {
                    transform = (CsRectTransformBean)d.Value;
                }
                else if ((int)EnumUIBeanKeys.RectMask2DBean == d.Key)
                {
                    mask2d = (CsRectMask2DBean)d.Value;
                }
            }

            _swithSelectedVitual = _csNormalLogicDesignOfUIVisualController.SwithSelectedVitual(transform, mask2d, (int)EnumSwitchStaus.Selected);
            UpdateUIVisuals();
        }
    }

    /// <summary>
    /// マウスポインタが離れた時
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerExit(PointerEventData eventData)
    {
        CsRectTransformBean transform = new CsRectTransformBean();
        CsRectMask2DBean mask2d = new CsRectMask2DBean();
        foreach (KeyValuePair<int, object> d in _swithSelectedVitual)
        {
            if ((int)EnumUIBeanKeys.RectTransformBean == d.Key)
            {
                transform = (CsRectTransformBean)d.Value;
            }
            else if ((int)EnumUIBeanKeys.RectMask2DBean == d.Key)
            {
                mask2d = (CsRectMask2DBean)d.Value;
            }
        }

        _swithSelectedVitual = _csNormalLogicDesignOfUIVisualController.SwithSelectedVitual(transform, mask2d, (int)EnumSwitchStaus.UnSelected);
        UpdateUIVisuals();
    }

    /// <summary>
    /// UI表示を切り替える
    /// </summary>
    private void UpdateUIVisuals()
    {
        CsRectTransformBean transform = new CsRectTransformBean();
        CsRectMask2DBean mask2d = new CsRectMask2DBean();
        foreach (KeyValuePair<int, object> d in _swithSelectedVitual)
        {
            if ((int)EnumUIBeanKeys.RectTransformBean == d.Key)
            {
                transform = (CsRectTransformBean)d.Value;
            }
            else if ((int)EnumUIBeanKeys.RectMask2DBean == d.Key)
            {
                mask2d = (CsRectMask2DBean)d.Value;
            }
        }

        // RectTransformを反映
        this.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(transform.posX, transform.posY, transform.posZ);
        this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.width, transform.height);

        // RectMask2Dを反映
        this.gameObject.GetComponent<RectMask2D>().padding = new Vector4(mask2d.paddingLeft, mask2d.paddingTop, mask2d.paddingRight, mask2d.paddingBottom);
    }
}
