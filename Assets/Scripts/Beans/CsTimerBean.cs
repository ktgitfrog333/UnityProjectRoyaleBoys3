using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// タイマー情報Beanクラス
/// </summary>
public class CsTimerBean
{
    /// <summary>オブジェクトを生成する周期を計測するタイマー</summary>
    public float cycleTime { get; set; }
    /// <summary>生成開始時間</summary>
    public float creationStartTime { get; set; }
    /// <summary>タイマー</summary>
    public float countTime { get; set; }

    /// <summary>
    /// タイマー情報管理クラスのコンストラクタ
    /// </summary>
    /// <param name="cycleTime">オブジェクトを生成する周期を計測するタイマー</param>
    /// <param name="creationStartTime">生成開始時間</param>
    /// <param name="countTime">タイマー</param>
    public CsTimerBean(float cycleTime, float creationStartTime, float countTime)
    {
        this.cycleTime = cycleTime;
        this.creationStartTime = creationStartTime;
        this.countTime = countTime;
    }

    /// <summary>
    /// タイマー情報管理クラスのコンストラクタ
    /// </summary>
    /// <param name="cycleTime">オブジェクトを生成する周期を計測するタイマー</param>
    /// <param name="creationStartTime">生成開始時間</param>
    public CsTimerBean(float cycleTime, float creationStartTime)
    {
        this.cycleTime = cycleTime;
        this.creationStartTime = creationStartTime;
    }
}
