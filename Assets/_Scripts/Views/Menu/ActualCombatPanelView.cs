using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoleMole
{

    public class ActualCombatPanelContext : BaseContext
    {
        public ActualCombatPanelContext()
            : base(UIType.ActualCombatPanel)
        {

        }
    }
    public class ActualCombatPanelView : AnimateView
    {

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
        }

        public override void OnPause(BaseContext context)
        {
            // _animator.SetTrigger("OnExit");
            this.gameObject.SetActive(false);
        }

        public override void OnResume(BaseContext context)
        {
            // _animator.SetTrigger("OnEnter");
            this.gameObject.SetActive(true);
        }
        /// <summary>
        /// 返回按钮返回对战界面
        /// </summary>
        public void BattlePanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new BattlePanelContext());
        }

        public void Mode5V5LoadPush()
        {
            Application.LoadLevel("5V5");
           
        }
    }
}



