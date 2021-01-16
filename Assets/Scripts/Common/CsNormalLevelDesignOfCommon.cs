using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 全体のパラメータを管理
/// </summary>
public static class CsNormalLevelDesignOfCommon
{
    /// <summary>
    /// 移動（左スティック）のHorizontal
    /// </summary>
    public static readonly string LEFT_HORIZONTAL = "Horizontal";
    /// <summary>
    /// 移動（左スティック）のHorizontal
    /// </summary>
    public static readonly string LEFT_VERTICAL = "Vertical";
    /// <summary>
    /// 視点（右スティック）のHorizontal
    /// </summary>
    public static readonly string RIGHT_HORIZONTAL = "Horizontal2";
    /// <summary>
    /// 視点（右スティック）のVertical
    /// </summary>
    public static readonly string RIGHT_VERTICAL = "Vertical2";
    /// <summary>
    /// CyMotor001オブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_CYLINDER_MOTOR = "CyMotor001";
    /// <summary>
    /// PiParts001オブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_PIPE_PARTS = "PiParts001";
    /// <summary>
    /// 数字（float）の０
    /// </summary>
    public static readonly float FLOAT_ZERO = 0f;
    /// <summary>
    /// 数字（int）の０
    /// </summary>
    public static readonly int INT_ZERO = 0;
    /// <summary>
    /// 弾の最大サイズ
    /// </summary>
    public static readonly float MAX_SIZE = 1.75f;
    /// <summary>
    /// 弾の最小サイズ
    /// </summary>
    public static readonly float MIN_SIZE = 0.01f;
    /// <summary>
    /// 大砲位置補正_X
    /// </summary>
    public static readonly float PIPE_PARTS_POSITION_X = 0.56919f;
    /// <summary>
    /// 大砲位置補正_Y
    /// </summary>
    public static readonly float PIPE_PARTS_POSITION_Y = 3.40777f;
    /// <summary>
    /// 大砲位置補正_Z
    /// </summary>
    public static readonly float PIPE_PARTS_POSITION_Z = -5.7214f;
}
