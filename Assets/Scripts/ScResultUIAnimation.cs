using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// オブジェクトUIのアニメーション制御するスクリプトクラス
/// </summary>
public class ScResultUIAnimation : MonoBehaviour
{
    /// <summary>親オブジェクト配下の子オブジェクトグループを格納</summary>
    private GameObject[] _gameObjects;
    /// <summary>新記録メッセージUI</summary>
    private GameObject _gameObject;
    /// <summary>プレイヤーのスコア情報</summary>
    public CsScoresBean _csScoresBean;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("制限時間:" + _csScoresBean.limitTime);
        Debug.Log("タイムカウンタ(s):" + _csScoresBean.countTime);
        Debug.Log("残り時間(s):" + _csScoresBean.nowTime);
        _gameObjects = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject g = transform.GetChild(i).gameObject;
            if (g.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_NEWRECORD))
            {
                _gameObject = g;
            }
        }
        StartCoroutine(AnimationsOfMessage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// メッセージを点滅させる
    /// </summary>
    /// <returns></returns>
    private IEnumerator AnimationsOfMessage()
    {
        while (true)
        {
            _gameObject.GetComponent<Image>().enabled = false;
            yield return new WaitForSeconds(0.05f);
            _gameObject.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
