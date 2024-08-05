using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cusor : MonoBehaviour
{
   [SerializeField] private Texture2D curso;
    private Vector2 cusor2;
    void Start()
    {
        cusor2 = new Vector2(curso.width / 2, curso.height / 2);
        Cursor.SetCursor(curso, cusor2 , CursorMode.Auto );
    }

    
}
