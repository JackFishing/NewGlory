using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  Base Animate View
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
	public abstract class AnimateView : BaseView 
    {
        [SerializeField]
        protected Animator _animator;

        public override void OnEnter(BaseContext context)
        {
            //_animator.SetTrigger("OnEnter");
           this.gameObject.SetActive(true);
        }

        public override void OnExit(BaseContext context)
        {
           // _animator.SetTrigger("OnExit");
           this.gameObject.SetActive(false);
        }

        public override void OnPause(BaseContext context)
        {
           // _animator.SetTrigger("OnPause");
            this.gameObject.SetActive(false);
        }

        public override void OnResume(BaseContext context)
        {
          //  _animator.SetTrigger("OnResume");
            this.gameObject.SetActive(true);
        }

	}
}
