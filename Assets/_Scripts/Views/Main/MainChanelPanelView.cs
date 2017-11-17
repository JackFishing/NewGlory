using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoleMole
{

    public class MainChanelPanelContext : BaseContext
    {
        public MainChanelPanelContext()
            : base(UIType.MainChanelPanel)
        {

        }
    }
    public class MainChanelPanelView : AnimateView
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
            //  _animator.SetTrigger("OnExit");
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
        public void MainMenuPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new MainMenuPanelContext());
        }
    }
}
