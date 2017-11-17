using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleMole
{

    public class BattleWatchingPanelContext : BaseContext
    {
        public BattleWatchingPanelContext()
            : base(UIType.BattleWatchingPanel)
        {

        }
    }
    public class BattleWatchingPanelView : AnimateView
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
        /// 返回按钮返回主界面
        /// </summary>
        public void MenuPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new MenuContext());
        }
    }
}

