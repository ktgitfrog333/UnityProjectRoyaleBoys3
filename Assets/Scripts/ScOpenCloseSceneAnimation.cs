using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// シーン遷移する際に背景スクロールアニメーションを入れるスクリプトクラス
/// </summary>
public class ScOpenCloseSceneAnimation : MonoBehaviour
{
    /// <summary>スクロール範囲：始点</summary>
    [SerializeField] private float _scrollRangeStart_X = 800f;

    /// <summary>スクロール範囲：終点</summary>
    [SerializeField] private float _scrollRangeEnd_X = 0f;

    // Start is called before the first frame update
    void Start()
    {
        OpenScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// シーンを開く
    /// </summary>
    private void OpenScene()
    {
        var transformCache = transform;
        // 終点として使用するため、初期座標を保持
        var defaultPosition = transformCache.localPosition;
        transformCache.localPosition = new Vector3(0f, 0f);
        // 移動アニメーション開始
        transformCache.DOLocalMove(defaultPosition, 1.0f)
            .SetEase(Ease.Linear);
    }

    /// <summary>
    /// シーンを閉じる
    /// </summary>
    public void CloseScene()
    {
        transform.localPosition = new Vector3(_scrollRangeEnd_X, transform.localPosition.y, transform.localPosition.z);
        var transformCache = transform;
        // 終点として使用するため、初期座標を保持
        var defaultPosition = transformCache.localPosition;
        transformCache.localPosition = new Vector3(_scrollRangeStart_X, 0f);
        // 移動アニメーション開始
        transformCache.DOLocalMove(defaultPosition, 1.0f)
            .SetEase(Ease.Linear);
    }
}
