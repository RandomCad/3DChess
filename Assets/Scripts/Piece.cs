using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Color
{
    WHITE,
    BLACK
}

public enum Type
{
    PAWN,
    ROOK,
    KNIGHT,
    BISHOP,
    QUEEN,
    KING
}

public class Piece : MonoBehaviour
{
    public Color color = Color.WHITE;
    public Type type = Type.PAWN;

    public bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (!moving && (x != 0 || z != 0))
        {
            if (x != 0) transform.Translate(new Vector3(x > 0 ? 1 : -1, 0, 0));
            if (z != 0) transform.Translate(new Vector3(0, 0, z > 0 ? 1 : -1));
            moving = true;
        } else if (moving && x == 0 && z == 0)
        {
            moving = false;
        }
    }
}
