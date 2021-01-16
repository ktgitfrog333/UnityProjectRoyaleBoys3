using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾を生成する制御スクリプトクラス
/// </summary>
public class ScBulletCreate : MonoBehaviour
{
    #pragma warning disable 649
    /// <summary>中心配置の弾Prefab</summary>
    [SerializeField] private GameObject _bulletCenter;

    /// <summary>弾の生成位置</summary>
    private CsTransformBean _csTransformBean;
    /// <summary>タイマー情報Beanクラス</summary>
    private CsTimerBean _csTimerBean;

    /// <summary>オブジェクトの位置補正クラス</summary>
    private CsNormalLogicDesignOffSets _csNormalLogicDesignOffSets;

    // Start is called before the first frame update
    void Start()
    {
        _csTimerBean = new CsTimerBean(7.5f, 1.5f + Random.Range(-0.5f, 0.5f));

        CsTransformBean bean = new CsTransformBean(0f, 0f, 0f);
        _csNormalLogicDesignOffSets = new CsNormalLogicDesignOffSets();
        bean = _csNormalLogicDesignOffSets.OffSetOfPipeParts(this.gameObject);

        if (0 != bean.position_x || 0 != bean.position_y || 0 != bean.position_z)
        {
            _csTransformBean = new CsTransformBean(bean.position_x, bean.position_y, bean.position_z);
            StartCoroutine(BulletCreateAndArrangement());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 弾の位置を指定して生成する
    /// 生成開始タイミングを砲台ごとにずらす
    /// 周期時間ごとに弾を生成する
    /// </summary>
    /// <returns>生成開始時間,オブジェクトを生成する周期を計測するタイマー</returns>
    private IEnumerator BulletCreateAndArrangement()
    {
        yield return new WaitForSeconds(_csTimerBean.creationStartTime);
        while (true)
        {
            Instantiate(_bulletCenter, new Vector3(_csTransformBean.position_x, _csTransformBean.position_y, _csTransformBean.position_z), Quaternion.identity);
            yield return new WaitForSeconds(_csTimerBean.cycleTime + Random.Range(-0.5f, 0.5f));
        }
    }
}
