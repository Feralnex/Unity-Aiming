using UnityEngine;
using UnityEngine.EventSystems;

class AimController : MonoBehaviour
{
    [SerializeField]
    private VirtualJoystick _virtualJoystick;

    public Movement Movement { get; private set; }

    protected void Awake()
    {
        Movement = GetComponent<Movement>();
    }

    protected void OnEnable()
    {
        _virtualJoystick.DragStart += OnDragStart;
        _virtualJoystick.DragStop += OnDragStop;
        _virtualJoystick.RelativeAngleChanged += OnAngleChanged;
    }

    protected void OnDisable()
    {
        _virtualJoystick.DragStart -= OnDragStart;
        _virtualJoystick.DragStop -= OnDragStop;
        _virtualJoystick.RelativeAngleChanged -= OnAngleChanged;
    }

    private void OnDragStart(PointerEventData eventData)
    {
        Movement.FacingDirection = true;
    }

    private void OnDragStop(PointerEventData eventData)
    {
        Movement.FacingDirection = false;
    }

    private void OnAngleChanged(float angleInRadians, float angleInDegrees)
    {
        Movement.FaceTowards(angleInDegrees);
    }
}
