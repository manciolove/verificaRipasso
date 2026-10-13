namespace verificaRipasso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] alfabeto = { "A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            string[] paroleCifr = new string[15];
            List <string> lettere = new List<string>();
            
            using (StreamReader sr = new StreamReader("paroleCifrate.txt"))
            {
                string riga = sr.ReadLine();

                for (int i = 1; i < paroleCifr.Length; i = i + 2)
                {
                    riga = sr.ReadLine();
                    paroleCifr[i] = riga;

                    for (int j = 1; j < paroleCifr[i].Length; j = j + 2)
                    {
                        lettere.Add(paroleCifr[i]);
                    }
                }
                for (int i = 0; i < lettere.Count; i++)
                {
                    for (int j = 0; j < alfabeto.Length; j = j + 2)
                    {
                        if (alfabeto[j] == lettere[i])
                        {

                        }
                    }
                }
            }
        }
    }
}
