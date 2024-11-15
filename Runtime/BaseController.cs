using System;
using UnityEngine;

namespace Commons.MVC
{
    public abstract class BaseController<TView, TContext> : BaseController
        where TView : BaseView
        where TContext : BaseContext
    {
        protected readonly TView View;
        protected readonly TContext Context;
        
        public BaseController(TView View, TContext Context)
        {
            this.View = View;
            this.Context = Context;
            this.Context.ResolveContext();
        }

        public override Type GetViewType()
        {
            return typeof(TView);
        }

        // public override void AssignView(IView baseView)
        // {
        //     View = baseView as TView;
        //     Context = gameObject.AddComponent<TContext>(); //to think about it
        //     Context.ResolveContext();
        // }

        public override void Setup()
        {
            CreateDispatcher();
            View.Setup();
        }
        protected virtual void CreateDispatcher() { }
    }

    public abstract class BaseController : MonoBehaviour, IController
    {
        public abstract void Setup();
        public abstract Type GetViewType();
        public abstract void AssignView(IView baseView);
    }

    public interface IController
    {
        public void Setup();
        public Type GetViewType();
        public void AssignView(IView baseView);
    }
}