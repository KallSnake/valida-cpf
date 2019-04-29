using System;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("informe seu CPF: ");
            string cpf = Console.ReadLine();


            // Console.WriteLine("Seu CPF: " + cpf);


            string n1 = (cpf.Substring(0, 1));

            // Console.WriteLine("Pos 1: " + n1); // ok

            string n2 = (cpf.Substring(1, 1));

            // Console.WriteLine("Pos 2: " + n2); // ok

            string n3 = (cpf.Substring(2, 1));

            // Console.WriteLine("Pos 3: " + n3); // ok

            string n4 = cpf.Substring(3, 1);

            // Console.WriteLine("Pos 4: " + n4); // ok

            string n5 = cpf.Substring(4, 1);

            // Console.WriteLine("Pos 5: " + n5); // ok

            string n6 = cpf.Substring(5, 1);

            // Console.WriteLine("Pos 6: " + n6); // ok

            string n7 = cpf.Substring(6, 1);

            // Console.WriteLine("Pos 7: " + n7); // ok

            string n8 = cpf.Substring(7, 1);

            // Console.WriteLine("Pos 8: " + n8); // ok

            string n9 = cpf.Substring(8, 1);

            // Console.WriteLine("Pos 9: " + n9); // ok

            string n10 = cpf.Substring(9, 1);

            // Console.WriteLine("Pos 10: " + n10); // ok

            string n11 = cpf.Substring(10, 1);

            // Console.WriteLine("Pos 11: " + n11); // ok


            float sum1 = 0f;
            float sum2 = 0f;
            float res1 = 0f;
            float res2 = 0f;


            if ( (!cpf.Length.Equals(11)) || (cpf.Equals("00000000000")) || (cpf.Equals("11111111111")) || (cpf.Equals("22222222222")) || (cpf.Equals("33333333333")) || (cpf.Equals("44444444444")) || (cpf.Equals("55555555555")) || (cpf.Equals("66666666666")) || (cpf.Equals("77777777777")) || (cpf.Equals("88888888888")) || (cpf.Equals("99999999999")))
            {

                Console.WriteLine();
                Console.WriteLine("informe seu CPF corretamente!");

            } else
            {

                // Console.WriteLine("informe seu CPF correto!");

                sum1 = ((Convert.ToSingle(n1) * 10) + (Convert.ToSingle(n2) * 9) + (Convert.ToSingle(n3) * 8) + (Convert.ToSingle(n4) * 7) + (Convert.ToSingle(n5) * 6) + (Convert.ToSingle(n6) * 5) + (Convert.ToSingle(n7) * 4) + (Convert.ToSingle(n8) * 3) + (Convert.ToSingle(n9) * 2));

                Console.WriteLine();
                // Console.WriteLine("Soma 1: " + sum1);

                res1 = (sum1 * 10) % 11;

                Console.WriteLine();
                // Console.WriteLine("Resto 1: " + res1);


                if (res1.Equals(10))
                {

                    res1 = 0;

                }


                sum2 = ((Convert.ToSingle(n1) * 11) + (Convert.ToSingle(n2) * 10) + (Convert.ToSingle(n3) * 9) + (Convert.ToSingle(n4) * 8) + (Convert.ToSingle(n5) * 7) + (Convert.ToSingle(n6) * 6) + (Convert.ToSingle(n7) * 5) + (Convert.ToSingle(n8) * 4) + (Convert.ToSingle(n9) * 3) + (Convert.ToSingle(n10) * 2));

                Console.WriteLine();
                // Console.WriteLine("Soma 2: " + sum2);

                res2 = (sum2 * 10) % 11;

                Console.WriteLine();
                // Console.WriteLine("Resto 2: " + res2);


                if (res2.Equals(10))
                {

                    res2 = 0;

                }


                // ((res1.Equals(num10)) && res2.Equals(num11)) ? Console.WriteLine("CPF válido!"); : Console.WriteLine("CPF inválido!"); 
               

                if ( (res1.Equals(Convert.ToSingle(n10))) && res2.Equals(Convert.ToSingle(n11)) )
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CPF válido!");

                } else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CPF inválido!");

                }



            }


            Console.WriteLine();
            Console.WriteLine();


            Console.ReadKey();


        }
    }
}
