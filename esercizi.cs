namespace SecondoGiorno
{
    public static class esercizi_secondogiorno

    {
        public static int PrimoEsercizio(int iPrimoNumero, int iSecondoNumero)
        {
            int iSomma;
            iSomma = iPrimoNumero + iSecondoNumero;
            return iSomma;
        }

        public static void RaddoppiaNumero(ref int iNumeroDaRaddoppiare)
        {
            iNumeroDaRaddoppiare = iNumeroDaRaddoppiare * 2;

        }

        public static void ModificaStringa(ref string sStringaDaModificare)
        {
            sStringaDaModificare = sStringaDaModificare + "adc";
        }

        public static float CalcolaMedia(int[] vVettoreInteri)
        {
            int iNumeriElementi = vVettoreInteri.Length;
            float fSomma = 0;
            for (int i = 0; i < iNumeriElementi; i++)
            {
                fSomma += vVettoreInteri[i];
            }
            fSomma = fSomma / (float)iNumeriElementi;

            return fSomma;
        }

        public static void CalcoloMedia()
        {
            double dSomma = 0;
            Console.WriteLine("di quanti numeri vuoi fare la media?");
            double iNumeroMedia = Convert.ToDouble(Console.ReadLine());
            for(int i = 0; i < iNumeroMedia; i++)
            {
                Console.WriteLine("inserisci numero:");
                double dNumber = Convert.ToDouble(Console.ReadLine());
                dSomma =+ dNumber; 
            }
            double dAverage = dSomma / iNumeroMedia;

            Console.WriteLine("la media é: {0}", dAverage);
            //return dAverage;

        }
        public static void CalcoloMediaArray()
        {
            double dAverageArray;


        }
    }
}

