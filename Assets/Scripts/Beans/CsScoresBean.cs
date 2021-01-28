using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーのスコア情報を管理するBean
/// </summary>
public class CsScoresBean
{
    /// <summary>制限時間</summary>
    public float limitTime { get; set; } = CsNormalLevelDesignOfCommon.FLOAT_ZERO;
    /// <summary>タイムカウンタ(s)</summary>
    public float countTime { get; set; } = CsNormalLevelDesignOfCommon.FLOAT_ZERO;
    /// <summary>残り時間(s)</summary>
    public float nowTime { get; set; } = CsNormalLevelDesignOfCommon.FLOAT_ZERO;
}
