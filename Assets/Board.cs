using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float offset;

    public int columns, rows;
    public float width;
    public GameObject square, blueShrine, redShrine;
    public GameObject blueMaster;

    private static int[,] Pieces;

    // Start is called before the first frame update
    void Start()
    {
        Pieces = new int[5, 5];
        Pieces[0, 0] = Piece.Blue | Piece.Student;
        Pieces[1, 0] = Piece.Blue | Piece.Student;
        Pieces[2, 0] = Piece.Blue | Piece.Student;
        Pieces[3, 0] = Piece.Blue | Piece.Student;
        Pieces[4, 0] = Piece.Blue | Piece.Student;

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                if (x == 2 && y == 0)
                {
                    Instantiate(blueShrine, new Vector3(x * width, y * width), Quaternion.identity);
                }
                else if (x == 2 && y == 4)
                {
                    Instantiate(redShrine, new Vector3(x * width, y * width), Quaternion.identity);
                }
                else
                {
                    Instantiate(square, new Vector3(x * width, y * width), Quaternion.identity);
                }

                if (Pieces[x, y] != 0)
                {
                    Instantiate(blueMaster, new Vector3(-2, -2, -1), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static class Piece
    {
        public const int None = 0;
        public const int Master = 1;
        public const int Student = 2;

        public const int Red = 8;
        public const int Blue = 16;
    }
}
