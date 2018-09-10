using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;



namespace LeetSpeakMVC.Models
 {
   public class LeetSpeak
   {
     private string _input;

     public string GetInput()
     {
       return _input;
     }
     public void SetInput(string newInput)
     {
       _input = newInput;
     }

     public string GetTranslate()
     {
       Regex rx = new Regex(@"^[a-zA-Z]+$");
       List<char> inputList = new List<char> { };
       List<char> outputList = new List<char> { };

       for(int i = 0; i < _input.Length; i++)
       {
         inputList.Add(_input[i]);
         if (inputList[i] == 'e')
         {
           outputList.Add('3');
         }
         else if(inputList[i] == 'o')
         {
           outputList.Add('0');
         }
         else if(inputList[i] == 't')
         {
           outputList.Add('7');
         }
         else if(inputList[i] == 'I')
         {
           outputList.Add('1');
         }
         else if(i > 1 && rx.IsMatch(inputList[i - 1].ToString()) && ((inputList[i] == 's') || (inputList[i] == 'S')))
         {
           outputList.Add('z');
         }
         else
         {
           outputList.Add(inputList[i]);
         }
       }
       string translatedOutput = string.Join("", outputList.ToArray());
       return translatedOutput;
     }
   }
 }


 // class Program
 // {
 //   public static void Main()
 //   {
 //
 //
 //   }
 // }
