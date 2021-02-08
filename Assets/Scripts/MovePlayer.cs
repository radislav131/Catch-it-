using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform Player1;
    [SerializeField]
    private float speed = 10f;
    void OnMouseDrag()
    {
        if (!player.lose) { 
        
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x < -2.42671f ? -2.42671f : mousePos.x;
            mousePos.x = mousePos.x > 2.42671f ? 2.42671f : mousePos.x;
            mousePos.y = mousePos.y > 5f ? 5f : mousePos.y;
            mousePos.y = mousePos.y < -4f ? -4f : mousePos.y;
            Player1.position = Vector2.MoveTowards(Player1.position,
                new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
        }
    }
}
