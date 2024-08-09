using System.Reflection;

namespace Calculator
{

	using System;
    using System.Numerics;

    public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			eExp = 5,
			eSquareRoot = 6,
			eReciprocal = 7,
			eFactorial = 8
        }

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v2.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		public static BigInteger resFactNumericAnswer;
        private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber( string KeyNumber )
		{
			stringAnswer = stringAnswer + KeyNumber;
			return( stringAnswer );
		}

		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static void CalcOperation( Operator calcOper )
		{
			if( stringAnswer != "" && !secondNumberAdded )
			{
				firstNumber = System.Convert.ToDouble( stringAnswer );
				calcOperation = calcOper;
				
				if( calcOper != Operator.eSquareRoot &&
                    calcOper != Operator.eReciprocal &&
                    calcOper != Operator.eFactorial )
					stringAnswer = "";
				
				decimalAdded = false;
			}			
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ",";
				else
					stringAnswer = "0,";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble (stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

                    case Operator.eExp:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;

                    case Operator.eSquareRoot:
                        numericAnswer = Math.Sqrt(firstNumber);
                        validEquation = true;
                        break;

                    case Operator.eReciprocal:
                        numericAnswer = 1 / firstNumber;
                        validEquation = true;
                        break;

					case Operator.eFactorial:
						validEquation = Factorial((int)firstNumber, out resFactNumericAnswer);
						numericAnswer = (double)resFactNumericAnswer;
						break;

                    default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}

        //--.
        public static void setManualAnswer( string valueIn )
		{
			stringAnswer = valueIn;
        }

        //--.
        public static bool Factorial(int n, out BigInteger answer)
        {
            int k;              // Loop counter
            BigInteger f;              // Working value
            bool ok = true;     // true if okay, false if not

            // Check the input value
            if (n < 0)
            {
                ok = false;
            }

            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }

            answer = f;

            return ok;
        }


        //--. discriminant calculation
        static double discriminant(in double a, in double b, in double c)
        {
            return (double)(b * b - 4 * a * c);
        }


        //--.
        public static int solutionQuadraticEquation(in double a, in double b, in double c, ref double x1, ref double x2)
        {
            //--.
            x1 = 0;
            x2 = 0;

            //--. Calculates the discriminant D to understand how many roots there will be
            //--. D < 0 - no roots, return -1
            //--. D = 0 - there is one root, return 0
            //--. D > 0, there are two different roots, return 1
            double D = discriminant(in a, in b, in c);

            //--.
            if (D < 0)
            {
                return -1;
            }


            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            //--.
            if (D == 0)
            {
                return 0;
            }

            //--.
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return 1;

        }

    }
}