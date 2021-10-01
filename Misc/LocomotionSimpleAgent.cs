using UnityEngine;
using UnityEngine.AI;

namespace hUtility
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(Animator))]
    public class LocomotionSimpleAgent : MonoBehaviour
    {
        private NavMeshAgent _agent;
        private Animator _anim;
        private Vector2 _smoothDeltaPosition = Vector2.zero;
        private Vector2 _velocity = Vector2.zero;

        public Transform Target;

        private void Start()
        {
            _anim = GetComponent<Animator>();
            _agent = GetComponent<NavMeshAgent>();
            // Don’t update position automatically
            _agent.updatePosition = false;
        }

        private void Update()
        {
            _agent.SetDestination(Target.position);
            var worldDeltaPosition = _agent.nextPosition - transform.position;

            // Map 'worldDeltaPosition' to local space
            var dx = Vector3.Dot(transform.right, worldDeltaPosition);
            var dy = Vector3.Dot(transform.forward, worldDeltaPosition);
            var deltaPosition = new Vector2(dx, dy);

            // Low-pass filter the deltaMove
            var smooth = Mathf.Min(1.0f, Time.deltaTime / 0.15f);
            _smoothDeltaPosition = Vector2.Lerp(_smoothDeltaPosition, deltaPosition, smooth);

            // Update velocity if time advances
            if (Time.deltaTime > 1e-5f)
                _velocity = _smoothDeltaPosition / Time.deltaTime;

            // Update animation parameters
            _anim.SetFloat("Turn", _velocity.x);
            _anim.SetFloat("Forward", _velocity.y);
        }

        private void OnAnimatorMove()
        {
            // Update position to agent position
            transform.position = _agent.nextPosition;
        }
    }
}