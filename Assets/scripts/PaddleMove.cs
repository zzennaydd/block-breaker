using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    private bool isDragging = false; // Paddle'�n s�r�klenip s�r�klenmedi�ini tutar
    private Vector2 mouseOffset;

    void Update()
    {
        // Mouse sol tu�una bas�ld�ysa ve paddle �zerinde t�klama varsa
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                mouseOffset = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        // Mouse s�r�klendi�inde paddle'� hareket ettir
        if (isDragging && Input.GetMouseButton(0))
        {
            Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x + mouseOffset.x, transform.position.y);
        }

        // Mouse b�rak�ld���nda s�r�kleme iptal edilir
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }
}

    
    

