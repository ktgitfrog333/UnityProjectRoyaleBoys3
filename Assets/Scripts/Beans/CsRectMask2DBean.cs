using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// RectMask2DのBeanクラス
/// </summary>
public class CsRectMask2DBean
{
    public float paddingLeft { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingRight { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingTop { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingBottom { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float softnessX { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float softnessY { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;

    public CsRectMask2DBean(RectMask2D rectMask2D)
    {
        Vector4 vector4 = rectMask2D.padding;
        this.paddingLeft = vector4.x;
        this.paddingTop = vector4.y;
        this.paddingRight = vector4.z;
        this.paddingBottom = vector4.w;
    }

    public CsRectMask2DBean()
    {
    }
}
