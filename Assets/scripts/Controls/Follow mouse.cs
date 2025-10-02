using UnityEngine;

public class Followmouse : MonoBehaviour
{
    // the  object that follows the player's mouse
    
        Vector3 pos;
        public float offset = 3f;
    
        void Update()
        {
            pos = Input.mousePosition;
            pos.z = offset;
            transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
    
    
}
