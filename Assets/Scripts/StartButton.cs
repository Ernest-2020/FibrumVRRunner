using UnityEngine;
namespace Assets.Scripts
{
    public class StartButton : MonoBehaviour
    {
        [SerializeField]
        private GameObject _buttonStart;
        public void ButtonStart()
        {
            Time.timeScale = 1;
            _buttonStart.SetActive(false);
        }
    }
}