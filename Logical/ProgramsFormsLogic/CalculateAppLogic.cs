using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_SimpleCalculetor.Logical.ProgramsFormsLogic
{
    internal class CalculateAppLogic
    {

      private  enum _enumOperation {Add='+',Sub='-',Mul='*',Div='/'};
      private  int _Side_1 = 0;
      private  int _Side_2 = 0;
      private  char _Operation = ' ';
        private char _Operations(char Oper) 
        {


            return Oper == '+' ? '+' : Oper == '-' ? '-' : Oper == '*' ? '*' : Oper == '/' ? '/' : '?';

        }

        private long _StartProce() 
        {

            switch (_Operation) 
            {

                case (char)_enumOperation.Add:
                    return _Side_1 + _Side_2;
              
                case (char)_enumOperation.Sub:
                    return _Side_1 - _Side_2;

                case (char)_enumOperation.Mul:
                    return _Side_1 * _Side_2;
                
                case (char)_enumOperation.Div:
                    return (_Side_2 != 0) ? _Side_1 / _Side_2: -1;




            }

            return 0;
        }


        private bool AddValue(string Text,int LengthSide) 
        {

            if (LengthSide == 0) return false;

            string Side1 = Text.Substring(0,LengthSide);
            string Side2 = Text.Substring(LengthSide + 1);

            _Side_1 = Convert.ToInt32(Side1);
            _Side_2 = Convert.ToInt32(Side2);
            _Operation = Text[LengthSide];

            return true;
        }
        private void FillArrOperation(bool[] arr, string Text)
        {
            for (int i = 0; i < Text.Length; i++)  
            {

                if (_Operations(Text[i]) != '?') 
                {
                    arr[i] = true;
                }

            }
        }

        private bool Filter(bool[] arr,int Length)  
        {

            bool Number_OR_Operation = true;






            return Number_OR_Operation;
        }
        private bool FindErrorsInText(bool[]arr,string Text) 
        {

            bool Number_OR_Operation = false;
            FillArrOperation(arr, Text);

            for (int i = 0;i < Text.Length;i++) 
            {

                if (Filter(arr,i)) 
                {

                    Number_OR_Operation = true;
                    break;
                }
                else 
                {
                    Number_OR_Operation = false;
                }

            }


            return Number_OR_Operation;
        }

        public long StartOperation_Calculator(string Text)
        {


            if (Text == "") return 0;

            int LengthSides = 0;
            bool[] ArrCountOperation = new bool[Text.Length];

            if (FindErrorsInText(ArrCountOperation,Text)) return -1;


            for (int i = 0; i < Text.Length; i++)
            {

                if (_Operations(Text[i]) != '?' && i != 0)
                {
                    LengthSides = i;
                    break;
                }

            }

            if (AddValue(Text, LengthSides))
            {
                return _StartProce();
            }

            return -1;

        }




    }
}
