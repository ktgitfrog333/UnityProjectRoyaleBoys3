using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// テキスト表示する際に様々な形式へ変換するクラス
/// </summary>
public class CsNormalLogicDesignOfConversion
{
    /// <summary>
    /// 秒をmm:ssの形式で返す
    /// </summary>
    /// <param name="second">秒</param>
    /// <returns>mm:ss形式の文字列</returns>
    public string ConversionSecondToMinutes(float second)
    {
        var span = new TimeSpan(0, 0, Mathf.FloorToInt(second));
        string mmss = span.ToString(@"mm\:ss");
        return mmss;
    }
}
