using System.IO;

namespace Bilgi_Sistemleri_3._Hafta_SSH_Brute_Force
{
    public static class Helpers
    {
        public static void GenerateNumbers()
        {
            using (var sw = new StreamWriter(@"C:\Users\BERKAY\Desktop\şifreler2.txt"))
            {
                for (int i = 1111; i <= 9999; i++)
                {
                    sw.WriteLine(i);
                }
            }

        }
    }
}