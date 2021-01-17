using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 床をベルトコンベアのように制御するスクリプトクラス
/// </summary>
public class ScConveyor : MonoBehaviour
{
    /// <summary>
    /// ベルトコンベアの稼働状況
    /// </summary>
    public bool IsOn = false;

    /// <summary>
    /// ベルトコンベアの設定速度
    /// </summary>
    public float TargetDriveSpeed = 3.0f;

    /// <summary>
    /// 現在のベルトコンベアの速度
    /// </summary>
    public float CurrentSpeed { get { return _currentSpeed; } }

    /// <summary>
    /// ベルトコンベアが物体を動かす方向
    /// </summary>
    public Vector3 DriveDirection = Vector3.forward;

    /// <summary>
    /// コンベアが物体を押す力（加速力）
    /// </summary>
    [SerializeField] private float _forcePower = 50f;

    private float _currentSpeed = 0;
    private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

    void Start()
    {
        StartCoroutine(ScrollAnimationMaterial());
        //方向は正規化しておく
        DriveDirection = DriveDirection.normalized;
    }

    void FixedUpdate()
    {
        _currentSpeed = IsOn ? TargetDriveSpeed : 0;

        //消滅したオブジェクトは除去する
        _rigidbodies.RemoveAll(r => r == null);

        foreach (var r in _rigidbodies)
        {
            //物体の移動速度のベルトコンベア方向の成分だけを取り出す
            var objectSpeed = Vector3.Dot(r.velocity, DriveDirection);

            //目標値以下なら加速する
            if (objectSpeed < Mathf.Abs(TargetDriveSpeed))
            {
                r.AddForce(DriveDirection * _forcePower, ForceMode.Acceleration);
            }
        }
    }

    /// <summary>
    /// マテリアルをスクロールする
    /// </summary>
    /// <returns></returns>
    private IEnumerator ScrollAnimationMaterial()
    {
        float count = 0f;
        while(true)
        {
            count -= Time.time;
            GetComponent<Renderer>().sharedMaterial.mainTextureOffset = new Vector2(count, 0f);
            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
        _rigidbodies.Add(rigidBody);
    }

    void OnCollisionExit(Collision collision)
    {
        var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
        _rigidbodies.Remove(rigidBody);
    }
}
