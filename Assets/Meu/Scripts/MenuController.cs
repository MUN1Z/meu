using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Meu.Scripts
{
    public class MenuController : MonoBehaviour {
    
        public TextMesh pointsText;
        public TextMesh lifesText;

        // Use this for initialization
        void Start () {
        }
	
        // Update is called once per frame
        void Update () {
        
            if (PlayerPrefs.GetInt("Lifes") < 1)
                PlayerPrefs.SetInt("Lifes", 1);

            pointsText.text = "Pontos: " + PlayerPrefs.GetFloat("PlayerScore");
            lifesText.text = "Vidas: " + PlayerPrefs.GetInt("Lifes");
        }

        public void StartButtonOnClick()
        {
            PlayerController._points = 0;
            GameManager.speed = -0.001f;
            GameManager.points = 0;
            SceneManager.LoadScene("game");
        }

        public void ShopButtonOnClick()
        {
            SceneManager.LoadScene("loja");
        }

        public void ExitButtonOnClick()
        {
            // save any game data here
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
                 Application.Quit();
        #endif
        }

    }
}
