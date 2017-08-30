using UnityEngine;

namespace Assets.Meu.Scripts
{
    public class GroundController : MonoBehaviour {
    
        void Update ()
        {
            Vector2 offSet = new Vector2(Time.time * 1, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offSet;
        }
    }
}
