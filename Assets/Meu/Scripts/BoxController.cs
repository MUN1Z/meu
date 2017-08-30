using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class BoxController : MonoBehaviour
    {

        private Vector3 _speed;

        private bool stop = false;

        // Use this for initialization
        void Start()
        {
            PlayerController.OnGameOver += Stop;
        }

        // Update is called once per frame
        void Update()
        {

            _speed += new Vector3(GameManager.speed, 0, 0);

            if (!stop)
            {
                transform.Translate(_speed);
                if (transform.position.x < -30f)
                    Destroy(gameObject);
            }
        }

        void Stop()
        {
            stop = true;
        }
    }
}
