using UnityEngine;
using System.Collections;

public enum SwipeDirection
{
    None = 0,
    left = 1,
    Right = 2,
    Up = 4,
    Down = 8,

    // LeftDown = 9,
    // LeftUp = 5,
    // RightDown = 10,
    // RightUp = 6
}
public class SwipeController : MonoBehaviour {
    private static SwipeController instance;
    public static SwipeController Instance{get {return instance;}}
    public SwipeDirection Direction{set; get;}
    private Vector3 touchPosition;
    private float swipeResistanceX = 50.0f;
    private float swipeResistanceY = 100.0f;
    
    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        Direction = SwipeDirection.None;

        if(Input.GetMouseButtonDown(0))
        {
            touchPosition = Input.mousePosition;
            // Debug.Log(touchPosition);
        }
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 deltaSwipe = touchPosition - Input.mousePosition;
            // Debug.Log(deltaSwipe);
            if(Mathf.Abs(deltaSwipe.x) > swipeResistanceX)
            {
                // Swipe on the X axis
                Direction |= (deltaSwipe.x < 0) ? SwipeDirection.Right : SwipeDirection.left;
            }
            if(Mathf.Abs(deltaSwipe.y) > swipeResistanceY)
            {
                // Swipe on the Y axis
                Direction |= (deltaSwipe.y < 0) ? SwipeDirection.Up : SwipeDirection.Down;
            }
        }
    }

    public bool IsSwiping(SwipeDirection dir)
    {
        return (Direction & dir) == dir;
    }
}
