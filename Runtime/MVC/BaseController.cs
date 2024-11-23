using System;
using UnityEngine;

namespace Commons.MVC
{
    public abstract class BaseController<TView, TModel, TContext> : BaseController
        where TView : IView
        where TContext : IContext
        where TModel : IModel
    {
        protected readonly TView View;
        protected readonly TContext Context;
        protected readonly TModel Model;

        public BaseController(TView view, TModel model, TContext context)
        {
            View = view;
            Context = context;
            Model = model;
            Context.ResolveContext();
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
            // View.Setup();
        }

        protected virtual void CreateDispatcher()
        {
        }
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