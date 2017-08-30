using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Meu.Scripts
{
    public class PlayerController : MonoBehaviour
    {

        public Vector3 jumpForce;
        public Vector3 fallForce;

        public float rotationAmout = 0.1f;
        public float maxRotationAngle = 20f;
        public float minRotationAngle = -60f;
        public float angleOffset = 15f;
        public bool isFloor = true;
        public static bool gameOver = false;
    
        public AudioClip deadSound;

        public AudioClip[] clips;
    
        public delegate void GameOver();
        public static event GameOver OnGameOver;
    
        private AudioSource aSource;

        public static int _points = 0;

        // Use this for initialization
        void Start()
        {
            aSource = GetComponent<AudioSource>();

            if (_points > 0)
            {
                GameManager.points = _points;
            }
        }
        
        void OnCollisionEnter(Collision col)
        {
            if (!gameOver && col.transform.tag == "Box")
            {
                gameOver = true;
                OnGameOver();
                GetComponentInChildren<Animator>().enabled = false;

                GameManager.aSource.Stop();
               
                aSource.volume = 1;
                aSource.clip = deadSound;
                aSource.Play();

                if (PlayerPrefs.GetInt("Lifes") > 1)
                {
                    SceneManager.LoadScene("over");
                }
                else
                {
                    if (PlayerPrefs.GetInt("PlayerRecord") < GameManager.points)
                        PlayerPrefs.SetInt("PlayerRecord", GameManager.points);

                    PlayerPrefs.SetFloat("PlayerScore", PlayerPrefs.GetFloat("PlayerScore") + GameManager.points);
                    SceneManager.LoadScene("menu");
                }

            }
            else
            {
                isFloor = true;
                gameOver = false;
            }
        }
    }
}
