using UnityEngine;
using UnityEngine.AI; 
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    void Update()
    {
        if (Mouse.current == null) return;
        if (Mouse.current.rightButton.wasPressedThisFrame) 
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}