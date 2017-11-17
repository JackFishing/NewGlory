using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MoleMole
{

    public class MainMenuPanelContext : BaseContext
    {
        public MainMenuPanelContext()
            : base(UIType.MainMenuPanel)
        {

        }
    }
    public class MainMenuPanelView : AnimateView
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
        public void MainChanelPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new MainChanelPanelContext());
        }
        public void SceneLoadButtonOnClick()
        {
            SceneManager.LoadScene("Menu");
            
        }
    }
}
