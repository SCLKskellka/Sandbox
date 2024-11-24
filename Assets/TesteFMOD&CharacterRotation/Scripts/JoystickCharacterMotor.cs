using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class JoystickCharacterMotor : MonoBehaviour
    {
        
        [SerializeField] private float xPower = 600;
        [SerializeField] private float yPower = 600;
        private Rigidbody _rb;

        private void Awake() {
            _rb = GetComponent<Rigidbody>();
        }

        public void MouvementJ(InputAction.CallbackContext ctx) {
            Vector2 vec = ctx.ReadValue<Vector2>();
            if(ctx.ReadValue<Vector2>().x > 0.1 || ctx.ReadValue<Vector2>().x < -0.1)
                vec.x = Mathf.Clamp(vec.x * xPower,-500f,500f);
            if(ctx.ReadValue<Vector2>().y > 0.1 || ctx.ReadValue<Vector2>().y < -0.1)
                vec.y = Mathf.Clamp(vec.y *yPower, -500f,500f);
            _rb.velocity = new Vector3(vec.x,0,vec.y) * Time.fixedDeltaTime;
        }
    }
}
