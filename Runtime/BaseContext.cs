using UnityEngine;
using UnityEngine.SceneManagement;

namespace Commons.MVC
{
    public abstract class BaseContext : MonoBehaviour, IContext
    {
        public MvcIntegrationManager MvcIntegrationManager { get; private set; }


        public virtual void ResolveContext()
        {
            MvcIntegrationManager = FindAnyObjectByType<MvcIntegrationManager>();
        }

        public BaseController AddView(IView view, Transform root)
        {
            var type = view.GetType();
            return MvcIntegrationManager.CreateAndAssignViewController(type, root);
        }

        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public interface IContext
    {
        public void ResolveContext();
    }
}