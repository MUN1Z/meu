using System.Collections;
using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class BoxSpawner : MonoBehaviour
    {

        public GameObject boxPrefab;

        public Vector3 offset;
        public float coolDownInit = 2;
        public float coolDownEnd = 5;
        public float accel = 1;
        public int size = -10;

        private bool stop = false;

        IEnumerator Spawn()
        {
            while (!stop)
            {
                Vector3 position = transform.position + new Vector3(Random.Range(-offset.x, offset.x),
                                       size,
                                       Random.Range(-offset.z, offset.z));

                Instantiate(boxPrefab, position, Quaternion.identity);


                yield return new WaitForSeconds(Random.Range(coolDownInit, coolDownEnd));
            }
        }


        void Stop()
        {
            stop = true;
        }

        // Use this for initialization
        void Start()
        {
            PlayerController.OnGameOver += Stop;

            StartCoroutine(Spawn());

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
