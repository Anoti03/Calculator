using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
   public float Number1 = 5f;
    public float Number2 = 3f;
    public float Result = 0f;
    public float ResultMinus = 0f;
    public float ResultMultiply = 0f;
    public float ResultDivide = 0f;
    public bool ConsoleNumber;
   public void Start()
    {
        Result = Number1 + Number2;
        ResultMinus = Number1 - Number2;
        ResultMultiply = Number1 * Number2;
        ResultDivide = Number1 / Number2;


        Debug.Log(Result);
        Debug.Log(ResultMinus);
        Debug.Log(ResultMultiply);
        Debug.Log(ResultDivide);
    }


   









}
