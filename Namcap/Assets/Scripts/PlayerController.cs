using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {

        public float Speed;
        // Update is called once per frame
        public void Update ()
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            var y = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

            Debug.Log($"x: {x} and y: {y}");
            var currentPos = transform.position;
            var newPos = new Vector3(x, y, currentPos.z);
            transform.Translate(newPos);
        }
    }
}
