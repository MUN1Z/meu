using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class GameManager : MonoBehaviour
    {

        public TextMesh pointsText;
        public TextMesh lifesText;

        public static int points;
        public static float speed = -0.001f;

        public static AudioSource aSource;


        public AudioClip background;

        public void AddPoints(int point)
        {
            points = points + point;
            pointsText.text = "Pontos: " + points;
            lifesText.text = "Vidas: " + PlayerPrefs.GetInt("Lifes");
            speed -= 0.001f;
        
            PlayerPrefs.SetFloat("PlayerPoints", points);

            PlayerController._points = points;
        }

        // Use this for initialization
        void Start()
        {
            aSource = GetComponent<AudioSource>();

            aSource.volume = 0.2f;
            aSource.clip = background;
            aSource.loop = true;
            aSource.Play();
        }

        // Update is called once per frame
        void Update()
        {
            lifesText.text = "Vidas: " + PlayerPrefs.GetInt("Lifes");

            pointsText.text = "Pontos: " + PlayerController._points;
        }
    }
}
