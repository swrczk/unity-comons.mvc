using UnityEngine;
using Zenject;

namespace Commons.MVC
{
    public abstract class BaseContext : MonoBehaviour, IContext
    {
        [Inject]
        public MvcController MvcController { get; private set; }


        public virtual void ResolveContext()
        {
            // MvcController = FindAnyObjectByType<MvcController>();
        }

        // public BaseController AddView(IView view, Transform root)
        // {
        //     var type = view.GetType();
        //     // return MvcController.CreateAndAssignViewController(type, root);
        //     return new BaseController();
        // }
        
    }

    public interface IContext
    {
        public void ResolveContext();
    }
}