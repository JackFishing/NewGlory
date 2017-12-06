/*
http://www.cgsoso.com/forum-257-1.html

CG搜搜 Unity3d 插件团购

CGSOSO 主打游戏开发，影视设计等CG资源素材。

每日Unity3d插件免费更新，仅限下载试用，如若商用，请务必官网购买！
*/

using System;
using UnityEngine;
using System.Collections;

public class CollisionActiveBehaviour : MonoBehaviour
{
  public bool IsReverse;
  public float TimeDelay = 0;
  public bool IsLookAt;

  private EffectSettings effectSettings;

	// Use this for initialization
	void Start ()
	{
	  GetEffectSettingsComponent(transform);
	  if (IsReverse) {
	    effectSettings.RegistreInactiveElement(gameObject, TimeDelay);
	    gameObject.SetActive(false);
	  }
	  else
	    effectSettings.RegistreActiveElement(gameObject, TimeDelay);
    if (IsLookAt) effectSettings.CollisionEnter += effectSettings_CollisionEnter;
	}

  void effectSettings_CollisionEnter(object sender, CollisionInfo e)
  {
    transform.LookAt(effectSettings.transform.position + e.Hit.normal);
  }

  private void GetEffectSettingsComponent(Transform tr)
  {
    var parent = tr.parent;
    if (parent != null)
    {
      effectSettings = parent.GetComponentInChildren<EffectSettings>();
      if (effectSettings == null)
        GetEffectSettingsComponent(parent.transform);
    }
  }
}
