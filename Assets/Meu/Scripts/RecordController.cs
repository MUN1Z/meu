using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class RecordController : MonoBehaviour {


        public TextMesh RecordText;

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
            RecordText.text = "Recorde: " + PlayerPrefs.GetInt("PlayerRecord");
        }
    }
}
