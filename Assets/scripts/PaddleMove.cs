using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    private bool isDragging = false; // Paddle'ýn sürüklenip sürüklenmediðini tutar
    private Vector2 mouseOffset;

    void Update()
    {
        // Mouse sol tuþuna basýldýysa ve paddle üzerinde týklama varsa
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                mouseOffset = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        // Mouse sürüklendiðinde paddle'ý hareket ettir
        if (isDragging && Input.GetMouseButton(0))
        {
            Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x + mouseOffset.x, transform.position.y);
        }

        // Mouse býrakýldýðýnda sürükleme iptal edilir
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }
}

    
    

