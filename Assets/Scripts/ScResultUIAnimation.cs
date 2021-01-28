using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// オブジェクトUIのアニメーション制御するスクリプトクラス
/// </summary>
public class ScResultUIAnimation : MonoBehaviour
{
    /// <summary>テキスト変換ロジック</summary>
    private CsNormalLogicDesignOfConversion _csNormalLogicDesignOfConversion;

    /// <summary>親オブジェクト配下の子オブジェクトグループを格納</summary>
    private GameObject[] _gameObjects;
    /// <summary>スコアタイムUI</summary>
    private GameObject _gameObjectScoreTime;
    /// <summary>新記録メッセージUI</summary>
    private GameObject _gameObject;
    /// <summary>プレイヤーのスコア情報</summary>
    public CsScoresBean _csScoresBean;

    // Start is called before the first frame update
    void Start()
    {
        _csNormalLogicDesignOfConversion = new CsNormalLogicDesignOfConversion();

        _gameObjects = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject g = transform.GetChild(i).gameObject;
            if (g.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_SCORETIME))
            {
                _gameObjectScoreTime = g;
                // タイムカウンタ(s)
                string time = "";
                if (Mathf.FloorToInt(_csScoresBean.nowTime) < 1)
                {
                    time = CsNormalLevelDesignOfCommon.TIME_OVER_SCORE;
                    GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_BACKGROUND_CLEAR).SetActive(false);
                }
                else
                {
                    time = _csNormalLogicDesignOfConversion.ConversionSecondToMinutes(_csScoresBean.countTime);
                    GameObject.Find(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_BACKGROUND_OVER).SetActive(false);
                }
                _gameObjectScoreTime.GetComponent<Text>().text = time;
            }
            else if (g.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_NEWRECORD))
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
