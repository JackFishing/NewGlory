using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoleMole
{

    public class  MenuContext : BaseContext
    {
        public MenuContext()
            : base(UIType.MenuPanel)
        {

        }
    }
    public class MunuPanelView : AnimateView
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
            //_animator.SetTrigger("OnExit");
            this.gameObject.SetActive(false);
        }

        public override void OnResume(BaseContext context)
        {
           // _animator.SetTrigger("OnEnter");
            this.gameObject.SetActive(true);
        }

        public void OptionCallBack()
        {
            //Singleton<ContextManager>.Instance.Push(new OptionMenuContext());
        }

        public void HighScoreCallBack()
        {
           // Singleton<ContextManager>.Instance.Push(new HighScoreContext());
        }

        /// <summary>
        /// 英雄界面
        /// </summary>
        public void HeroPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new HeroPanelContext());
        }
        /// <summary>
        /// 成就
        /// </summary>
        public void AchievementSystemPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new AchievementSystemPanelContext());
        }
        /// <summary>
        /// 战队界面
        /// </summary>
        public void TeamPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new TeamPanelContext());
        }
        /// <summary>
        /// 背包
        /// </summary>
        public void knapsackPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new knapsackPanelContext());
        }
        /// <summary>
        /// 成长
        /// </summary>
        public void GrowthSystemPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new GrowthSystemPanelContext());
        }
        /// <summary>
        /// 观战
        /// </summary>
        public void BattleWatchingPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new BattleWatchingPanelContext());
        }
        /// <summary>
        /// 商店
        /// </summary>
        public void StorePanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new StorePanelContext());
        }
        /// <summary>
        /// 聊天交流
        /// </summary>
        public void CommunityPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new CommunityPanelContext());
        }

        /// <summary>
        /// 赛事
        /// </summary>
        public void CompetitionPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new CompetitionPanelContext());
        }
        /// <summary>
        /// 活动
        /// </summary>
        public void ActivityPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new ActivityPanelContext());
        }

        public void InscriptionPanelViewCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new InscriptionPanelContext());
        }
    }
}
