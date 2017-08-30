using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class PointsController : MonoBehaviour {

        GameManager gameManager;

        // Use this for initialization
        void Start()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void ScorePoint(int point)
        {

        }


    
        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Player")
                gameManager.AddPoints(1);
        }
    }
}
