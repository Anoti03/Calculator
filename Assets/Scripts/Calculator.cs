using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Calculator : MonoBehaviour
{
   public float Number1 = 0f;
    public float Number2 = 0f;
    public float NumberMinus1 = 0f;
    public float NumberMinus2 = 0f;
    public float NumberMultiply1 = 0f;
    public float NumberMultiply2 = 0f;
    public float NumberDivide1 = 0f;
    public float NumberDivide2 = 0f;
    private float Result = 0f;
    private float ResultMinus = 0f;
    private float ResultMultiply = 0f;
    private float ResultDivide = 0f;
    
   public void Start()
    {
        Result = Number1 + Number2;
        ResultMinus = NumberMinus1 - NumberMinus2;
        ResultMultiply = NumberMultiply1 * NumberMultiply2;
        ResultDivide = NumberDivide1 / NumberDivide2;


        Debug.Log(Result);
        Debug.Log(ResultMinus);
        Debug.Log(ResultMultiply);
        Debug.Log(ResultDivide);
    }


   









}
