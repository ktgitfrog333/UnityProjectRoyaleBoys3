using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UIの表示処理を制御するクラス
/// </summary>
public class CsNormalLogicDesignOfUIVisualController
{
    /// <summary>選択状態</summary>
    public bool _switchStatus { get; set; } = false;

    /// <summary>
    /// ImageのPosisionとPaddingを移動させることで切り替え表示を実現するクラス
    /// </summary>
    /// <param name="csRectTransformBean">変更前のRectTransform情報</param>
    /// <param name="csRectMask2DBean">変更前のRectMask2D情報</param>
    /// <param name="cases">切り替え状態（UnSelected/Selected）</param>
    /// <returns>変更後の情報</returns>
    public IDictionary<int, object> SwithSelectedVitual(CsRectTransformBean csRectTransformBean, CsRectMask2DBean csRectMask2DBean, int cases)
    {
        IDictionary<int, object> afterTransforms = new Dictionary<int, object>();

        if ((int)EnumSwitchStaus.UnSelected == cases)
        {
            _switchStatus = false;

            CsRectTransformBean bean1 = new CsRectTransformBean();
            bean1 = csRectTransformBean;
            bean1.posX = bean1.posX + (bean1.width / 2);
            afterTransforms.Add((int)EnumUIBeanKeys.RectTransformBean, bean1);

            CsRectMask2DBean bean2 = new CsRectMask2DBean();
            bean2 = csRectMask2DBean;
            bean2.paddingLeft = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
            bean2.paddingRight = bean2.paddingRight + (bean1.width / 2);
            afterTransforms.Add((int)EnumUIBeanKeys.RectMask2DBean, bean2);
        }
        else if ((int)EnumSwitchStaus.Selected == cases)
        {
            _switchStatus = true;

            CsRectTransformBean bean1 = new CsRectTransformBean();
            bean1 = csRectTransformBean;
            bean1.posX = bean1.posX - (bean1.width / 2);
            afterTransforms.Add((int)EnumUIBeanKeys.RectTransformBean, bean1);

            CsRectMask2DBean bean2 = new CsRectMask2DBean();
            bean2 = csRectMask2DBean;
            bean2.paddingLeft = bean2.paddingLeft + (bean1.width / 2);
            bean2.paddingRight = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
            afterTransforms.Add((int)EnumUIBeanKeys.RectMask2DBean, bean2);
        }

        return afterTransforms;
    }
}
