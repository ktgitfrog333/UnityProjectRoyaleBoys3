using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゴール制御するスクリプトクラス
/// </summary>
public class ScGoalSequence : MonoBehaviour
{
    Vector3 _position;
    CsTransformBean _csTransformBean;

    // Start is called before the first frame update
    void Start()
    {
        _position = this.transform.position;
        StartCoroutine(MoveFloatUp());
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(_position.x, Mathf.Sin(Time.time) * 2.0f + _position.y, _position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StopCoroutine(MoveFloatUp());
    }

    /// <summary>
    /// 現在位置からY方向へ移動して、元へ戻る
    /// <para/>浮遊しているような動きにする
    /// </summary>
    /// <returns></returns>
    private IEnumerator MoveFloatUp()
    {
        while (true)
        {
            this.transform.position = new Vector3(_position.x, Mathf.Sin(Time.time) * 2.0f + _position.y, _position.z);
            yield return null;
        }
    }
}
