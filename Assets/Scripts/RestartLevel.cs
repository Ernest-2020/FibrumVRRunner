using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class RestartLevel : MonoBehaviour
    {

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
}