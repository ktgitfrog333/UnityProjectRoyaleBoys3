using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// オブジェクトの位置補正クラス
/// </summary>
public class CsNormalLogicDesignOffSets
{
    /// <summary>
    /// 砲台の発射位置を調整して、transformBeanを返す
    /// </summary>
    /// <param name="gameObject">砲台親オブジェクト</param>
    /// <returns>補正後の位置情報</returns>
    public CsTransformBean OffSetOfPipeParts(GameObject gameObject)
    {
        CsTransformBean bean = new CsTransformBean(0f, 0f, 0f);
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            GameObject g = gameObject.transform.GetChild(i).gameObject;
            if (g.name.Equals(CsNormalLevelDesignOfCommon.GAMEOBJECT_NAME_PIPE_PARTS))
            {
                bean.position_x = g.transform.position.x + CsNormalLevelDesignOfCommon.PIPE_PARTS_POSITION_X;
                bean.position_y = g.transform.position.y + CsNormalLevelDesignOfCommon.PIPE_PARTS_POSITION_Y;
                bean.position_z = g.transform.position.z + CsNormalLevelDesignOfCommon.PIPE_PARTS_POSITION_Z;
            }
        }
        return bean;
    }
}
