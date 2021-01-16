using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 指定位置を中心に回転する動きを制御するスクリプトクラス
/// </summary>
public class ScMotorSpin : MonoBehaviour
{
    /// <summary>MotorSpin親オブジェクト配下の子オブジェクトグループを格納</summary>
    private GameObject[] _gameObjects;

    /// <summary>中心点</summary>
    private Vector3 _center;
    /// <summary>回転軸</summary>
    [SerializeField] private Vector3 _axis = Vector3.up;
    /// <summary>円運動周期</summary>
    [SerializeField] private float _period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        _gameObjects = new GameObject[transform.parent.childCount];
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            GameObject g = transform.parent.GetChild(i).gameObject;
            if (g.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_CYLINDER_MOTOR))
            {
                _center = g.transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_center != null && !ReferenceEquals(_center, null))
        {
            // 中心点centerの周りを、軸axisで、period周期で円運動
            transform.RotateAround(_center, _axis, 360 / _period * Time.deltaTime);
        }
    }
}
