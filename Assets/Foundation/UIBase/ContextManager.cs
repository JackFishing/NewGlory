using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
/*
 *	
 *  Manage Context For UI Stack
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
    public class ContextManager
    {
        //定义一个存储BaseContext的栈
        private Stack<BaseContext> _contextStack = new Stack<BaseContext>();

        /// <summary>
        /// 构造函数 创建初始界面
        /// 根据场景创建初始界面
        /// </summary>
        private ContextManager()
        {
            if (SceneManager.GetActiveScene().name == "Main")
            {
                Push(new MainMenuPanelContext());
            }
            else if (SceneManager.GetActiveScene().name == "Menu")
            {
                Push(new MenuContext());
            }
           
        }

        /// <summary>
        ///  退出当前界面 让传入的界面显示
        /// </summary>
        /// <param name="nextContext"></param>
        public void Push(BaseContext nextContext)
        {
            if (_contextStack.Count != 0)
            {
                BaseContext curContext = _contextStack.Peek();//返回栈顶部的当前的对象 但是不删除它
                BaseView curView = Singleton<UIManager>.Instance.GetSingleUI(curContext.ViewType).GetComponent<BaseView>();//根据路径克隆生成UI物体并获取BaseView
                curView.OnPause(curContext);//退出当前界面
            }

            _contextStack.Push(nextContext);//把传入的nextContext推入栈的顶部
            BaseView nextView = Singleton<UIManager>.Instance.GetSingleUI(nextContext.ViewType).GetComponent<BaseView>();//根据路径克隆生成UI物体并获取BaseView
            nextView.OnEnter(nextContext);//让该物体进入界面显示
        }

        /// <summary>
        /// 退出当前的界面 并显示上一个界面
        /// </summary>
        public void Pop()
        {
            if (_contextStack.Count != 0)
            {
                BaseContext curContext = _contextStack.Peek();//返回但是不移除栈顶部的对象
                _contextStack.Pop();//移除并返回顶部的对象

                BaseView curView = Singleton<UIManager>.Instance.GetSingleUI(curContext.ViewType).GetComponent<BaseView>();
                curView.OnExit(curContext);//退出界面显示
            }

            if (_contextStack.Count != 0)
            {
                BaseContext lastContext = _contextStack.Peek();//返回但是不移除栈顶部的对象，获取上一个对象
                BaseView curView = Singleton<UIManager>.Instance.GetSingleUI(lastContext.ViewType).GetComponent<BaseView>();
                curView.OnResume(lastContext);//恢复上一个对象
            }
        }

        public BaseContext PeekOrNull()
        {
            if (_contextStack.Count != 0)
            {
                return _contextStack.Peek();
            }
            return null;
        }
    }
}
