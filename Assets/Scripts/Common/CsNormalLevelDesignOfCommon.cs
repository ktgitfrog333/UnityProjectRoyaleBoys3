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
    /// ユニティちゃんオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_UNITYCHAN = "unitychan";
    /// <summary>
    /// NewRecordのUIオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_NEWRECORD = "ImNewRecord";
    /// <summary>
    /// CaResultのUIオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_CANVASRESULT = "CaResult";
    /// <summary>
    /// TemScoreTimeのUIオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_SCORETIME2 = "TemScoreTime";
    /// <summary>
    /// ImBackground_ClearのUIオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_BACKGROUND_CLEAR = "ImBackground_Clear";
    /// <summary>
    /// ImBackground_OverのUIオブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_BACKGROUND_OVER = "ImBackground_Over";
    /// <summary>
    /// ImTimer01オブジェクト
    /// </summary>
    public static readonly string GAMEOBJECT_NAME_IMTIMER01 = "ImTimer01";
    /// <summary>
    /// タイトル画面のシーン名
    /// </summary>
    public static readonly string SCENES_NAME_01_TITLE = "01_Title";
    /// <summary>
    /// リザルト画面のシーン名
    /// </summary>
    public static readonly string SCENES_NAME_03_RESULT = "03_Result";
    /// <summary>
    /// InputManager設定キー名称 Horizontal3
    /// </summary>
    public static readonly string INPUT_MANAGER_AXIS_HORIZONTAL3 = "Horizontal3";
    /// <summary>
    /// InputManager設定キー名称 Submit
    /// </summary>
    public static readonly string INPUT_MANAGER_BUTTON_SUBMIT = "Submit";
    /// <summary>
    /// 時間切れになった時の表示文字列
    /// </summary>
    public static readonly string TIME_OVER_SCORE = "--:--";
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
    /// 位置、幅、高さの初期値（0）
    /// </summary>
    public static readonly float OFFSET_NUMBER = 0.0f;
    /// <summary>
    /// スケールの初期値（1）
    /// </summary>
    public static readonly float OFFSET_NUMBER_SCALE = 1.0f;
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
    /// <summary>
    /// 真を表すBoolean
    /// </summary>
    public static readonly bool TRUE = true;
    /// <summary>
    /// 偽を表すBoolean
    /// </summary>
    public static readonly bool FALSE = false;
}
