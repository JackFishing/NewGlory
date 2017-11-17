using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoleMole
{

    public class TeamPanelContext : BaseContext
    {
        public TeamPanelContext()
            : base(UIType.TeamPanel)
        {

        }
    }
    public class TeamPanelView : AnimateView
    {

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
            this.gameObject.SetActive(true);
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
            this.gameObject.SetActive(false);
        }

        public override void OnPause(BaseContext context)
        {
           // _animator.SetTrigger("OnExit");
            this.gameObject.SetActive(false);
        }

        public override void OnResume(BaseContext context)
        {
          //  _animator.SetTrigger("OnEnter");
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
