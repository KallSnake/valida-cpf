using System;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("informe seu CPF: ");
            string cpf = Console.ReadLine();


            // Console.Write("Seu CPF: " + cpf);


            string n1 = cpf.Substring(1,1);
            string n2 = cpf.Substring(2,1);
            string n3 = cpf.Substring(3,1);
            string n4 = cpf.Substring(4,1);
            string n5 = cpf.Substring(5,1);
            string n6 = cpf.Substring(6,1);
            string n7 = cpf.Substring(7,1);
            string n8 = cpf.Substring(8,1);
            string n9 = cpf.Substring(9,1);
            string n10 = cpf.Substring(10,1);
            string n11 = cpf.Substring(11,1);
            float sum1 = 0f;
            float sum2 = 0f;
            float res1 = 0f;
            float res2 = 0f;


            if (cpf.Length < 11 || cpf.Length > 11)
            {

                Console.WriteLine("informe seu CPF corretamente!");

            } else
            {

                // Console.WriteLine("informe seu CPF correto!");

                sum1 = ((Convert.ToSingle(n1) * 10) + (Convert.ToSingle(n2) * 9) + (Convert.ToSingle(n3) * 8) + (Convert.ToSingle(n4) * 7) + (Convert.ToSingle(n5) * 6) + (Convert.ToSingle(n6) * 5) + (Convert.ToSingle(n7) * 4) + (Convert.ToSingle(n8) * 3) + (Convert.ToSingle(n9) * 2));

                res1 = (sum1 * 10) % 11;


                if (res1.Equals(10))
                {

                    res1 = 0;

                }


                sum2 = ((Convert.ToSingle(n1) * 11) + (Convert.ToSingle(n2) * 10) + (Convert.ToSingle(n3) * 9) + (Convert.ToSingle(n4) * 8) + (Convert.ToSingle(n5) * 7) + (Convert.ToSingle(n6) * 6) + (Convert.ToSingle(n7) * 5) + (Convert.ToSingle(n8) * 4) + (Convert.ToSingle(n9) * 3) + (Convert.ToSingle(n10) * 2));

                res2 = (sum2 * 10) % 11;



                if (res2.Equals(10))
                {

                    res2 = 0;

                }


                float num10 = Convert.ToSingle(n10);
                float num11 = Convert.ToSingle(n11);



                ((res1 = num10) && (res2 = num11)) ? Console.WriteLine("CPF válido!") : Console.WriteLine("CPF inválido!") 
               


            }


            Console.ReadKey();


        }
    }
}
