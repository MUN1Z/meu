using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Meu.Scripts
{
    public class OverController : MonoBehaviour {

        public TextMesh pointsText;
        public TextMesh lifesText;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            pointsText.text = "Pontos: " + PlayerController._points;
            lifesText.text = "Vidas: " + PlayerPrefs.GetInt("Lifes");
        }

        public void ContinueButtonOnClick()
        {
            var lifes = PlayerPrefs.GetInt("Lifes");
            
            lifes -= 1;
            
            PlayerPrefs.SetInt("Lifes", lifes);

            SceneManager.LoadScene("game");
        }

        public void MenuBttonOnClick()
        {
            SceneManager.LoadScene("menu");
            PlayerPrefs.SetFloat("PlayerScore", PlayerPrefs.GetFloat("PlayerScore") + PlayerController._points);

            if(PlayerPrefs.GetInt("PlayerRecord") < PlayerController._points)
                PlayerPrefs.SetInt("PlayerRecord", PlayerController._points);

            PlayerController._points = 0;
        }
    }
}
