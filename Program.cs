namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete spisuk ot cvetove > Done za krai");
            List<string> colorlist = new List<string>();
            string Input = Console.ReadLine();
            while(Input != "Done")
            {
              colorlist.Add(Input);
                Input = Console.ReadLine();
            }

            Console.WriteLine("Koi element da iztriesh 0-" + (colorlist.Count-1));
            int index=int.Parse(Console.ReadLine());

            colorlist.RemoveAt(index);

            colorlist[0] = "Pink";


            //for(int i = 0; i < colorlist.Count; i++)
            // {
            //     Console.WriteLine(colorlist[1]);
            // }
            foreach (string chervenokvadratche in colorlist)
            {
                Console.WriteLine(chervenokvadratche);
            }
        }
    }
}
