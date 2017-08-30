using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Meu.Scripts
{
    public class ShopController : MonoBehaviour {

        public TextMesh pointsText;
        public TextMesh lifesText;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            pointsText.text = "Pontos: " + PlayerPrefs.GetFloat("PlayerScore");
            lifesText.text = "Vidas: " + PlayerPrefs.GetInt("Lifes");
        }

        public void LifeButtonOnClick()
        {
            var score = PlayerPrefs.GetFloat("PlayerScore");
            var lifes = PlayerPrefs.GetInt("Lifes");

            if (score > 10)
            {
                score -= 10;
                lifes += 1;

                PlayerPrefs.SetFloat("PlayerScore", score);
                PlayerPrefs.SetInt("Lifes", lifes);
            }
        }

        public void BackButtonOnClick()
        {
            SceneManager.LoadScene("menu");
        }
    }
}
