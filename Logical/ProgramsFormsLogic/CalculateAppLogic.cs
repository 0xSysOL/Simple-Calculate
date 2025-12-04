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
        private bool _Operations(char Oper) 
        {


            return Oper == '+' || Oper == '-' || Oper == '*' || Oper == '/';
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
                    return _Side_1 / _Side_2;




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
        public long StartOperation_Calculator(string Text)
        {
            if (Text == "") return 0;

            int LengthSides = 0;
            for (int i = 0; i < Text.Length; i++)
            {

                if (_Operations(Text[i]))
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
