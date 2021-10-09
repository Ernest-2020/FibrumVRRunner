using UnityEngine;

namespace Assets.Scripts
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private RectTransform _canvas;
        [SerializeField] private Transform _player;
        [SerializeField] private GameObject _button;
        

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                Time.timeScale = 0;
                _canvas.transform.position = _player.transform.position+new Vector3(0,0,200);
                _button.SetActive(true);
            }
        }

        private void Update()
        {
            
        }
    }
}