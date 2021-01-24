using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// RectTransformのBeanクラス
/// </summary>
public class CsRectTransformBean : CsInspectorBean
{
    public float posX { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float posY { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float posZ { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float width { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float height { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float scale_X { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER_SCALE;
    public float scale_Y { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER_SCALE;
    public float scale_Z { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER_SCALE;

    public CsRectTransformBean(RectTransform rectTransform)
    {
        this.posX = rectTransform.position.x;
        this.posY = rectTransform.position.y;
        this.posZ = rectTransform.position.z;
        this.width = rectTransform.sizeDelta.x;
        this.height = rectTransform.sizeDelta.y;
        this.scale_X = rectTransform.localScale.x;
        this.scale_Y = rectTransform.localScale.y;
        this.scale_Z = rectTransform.localScale.z;
    }

    public CsRectTransformBean()
    {
        
    }
}
