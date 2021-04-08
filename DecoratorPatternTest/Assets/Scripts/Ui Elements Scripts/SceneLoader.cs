using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ui_Elements_Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        public static event Action<int> SceneLoadEvent;

        public static void OnSceneLoadEvent(int obj)
        {
            SceneLoadEvent?.Invoke(obj);
        }

        private void OnEnable()
        {
            SceneLoadEvent += Loader;
        }

        private void OnDisable()
        {
            SceneLoadEvent -= Loader;
        }

        private void Loader(int scene)
        {     
            
            SceneManager.LoadScene(scene,LoadSceneMode.Single);
        }
    }
}
