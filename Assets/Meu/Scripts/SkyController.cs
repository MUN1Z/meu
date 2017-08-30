using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class SkyController : MonoBehaviour
    {

        public float Speed;

        // Update is called once per frame
        void Update () {
		    Vector2 offSet = new Vector2(Time.time * Speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offSet;
        }
    }
}
