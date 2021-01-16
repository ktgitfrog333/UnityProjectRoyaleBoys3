using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾を飛ばす制御をするスクリプトクラス
/// </summary>
public class ScBulletShot : MonoBehaviour
{
    #pragma warning disable 649
    /// <summary>力を加える位置x</summary>
    [SerializeField] private float _v3x;
    /// <summary>力を加える位置y</summary>
    [SerializeField] private float _v3y;
    /// <summary>力を加える位置z</summary>
    [SerializeField] private float _v3z;
    /// <summary>インパクト値</summary>
    [SerializeField] private float _forceMagnitude;

    /// <summary>タイマー</summary>
    private float _timer;
    /// <summary>オブジェクトを消す時間</summary>
    [SerializeField] private float _destroyTimer;
    private float _size;

    // Start is called before the first frame update
    void Start()
    {
        _timer = CsNormalLevelDesignOfCommon.FLOAT_ZERO;
        _size = CsNormalLevelDesignOfCommon.MIN_SIZE;
        this.gameObject.transform.localScale = new Vector3(_size, _size, _size);

        Vector3 forceDirection = new Vector3(_v3x, _v3x, _v3z);
        Vector3 force = _forceMagnitude * forceDirection;

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // ボールサイズを大きくする
        if (_size < CsNormalLevelDesignOfCommon.MAX_SIZE)
        {
            _size += 0.25f;
            this.gameObject.transform.localScale = new Vector3(_size, _size, _size);
        }

        // ボールを消すタイマー
        if (_destroyTimer < _timer)
        {
            Destroy(this.gameObject);
        }
        _timer += Time.deltaTime;
    }
}
