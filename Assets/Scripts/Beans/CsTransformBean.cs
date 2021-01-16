using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TransformBeanクラス
/// </summary>
public class CsTransformBean
{
    /// <summary>位置_X</summary>
    public float position_x { get; set; }
    /// <summary>位置_Y</summary>
    public float position_y { get; set; }
    /// <summary>位置_Z</summary>
    public float position_z { get; set; }

    /// <summary>
    /// TransformBeanクラスのコンストラクタ
    /// </summary>
    /// <param name="position_x">位置_X</param>
    /// <param name="position_y">位置_Y</param>
    /// <param name="position_z">位置_Z</param>
    public CsTransformBean(float position_x, float position_y, float position_z)
    {
        this.position_x = position_x;
        this.position_y = position_y;
        this.position_z = position_z;
    }
}
