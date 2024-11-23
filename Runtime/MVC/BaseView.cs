using UnityEngine;

namespace Commons.MVC
{
    public abstract class BaseView<TModel> : MonoBehaviour, IView
        where TModel : IModel
    {
        protected TModel Model;

        private void Start()
        {
            RegisterEvents();
        }
        public virtual void Setup(TModel model)
        {
            Model = model;
        }

        private void OnDestroy()
        {
            UnregisterEvents();
        }

        protected virtual void RegisterEvents()
        {
        }

        protected virtual void UnregisterEvents()
        {
        }

    }

    public abstract class BaseMainView<TModel> : BaseView<TModel>, IMainView
        where TModel : IModel
    {
    }

    public interface IView
    {
    }

    public interface IMainView
    {
    }
}