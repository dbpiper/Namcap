using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {

        private Rigidbody2D rigidbody;

        public float Speed;

        public void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        public void Update ()
        {
            NoAngularDrag();
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            var y = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

            var currentPos = transform.position;
            var newPos = new Vector3(x, y, currentPos.z);
            transform.Translate(newPos);
            transform.Translate(new Vector3(0f, 0f, 0f));
        }

        public void OnCollisionEnter()
        {
            NoAngularDrag();
        }

        public void OnCollisionStay()
        {
            NoAngularDrag();
        }

        private void NoAngularDrag()
        {
            rigidbody.angularDrag = 0f;
            rigidbody.angularVelocity = 0f;
            rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
