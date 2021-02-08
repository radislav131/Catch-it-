using UnityEngine;

public class ManyS : MonoBehaviour
{
    
   
        void OnTriggerEnter2D(Collider2D other)
        {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
            text.count++;
            
            
        }
}
