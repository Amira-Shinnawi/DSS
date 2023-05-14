using System.Diagnostics.Metrics;

namespace Apriori_Algorith_Implementation
{
    public partial class Form1 : Form
    {
        List<List<string>> transactions = new List<List<string>>();
        int y = 86;
        int minSupport = 2;
        public Form1()
        {
            InitializeComponent();    
        }

        static List<List<string>> AprioriAlgorithm(List<List<string>> transactions, int minSupport)
        {
            // Create list of unique items
            List<string> uniqueItems = transactions.SelectMany(x => x).Distinct().OrderBy(x => x).ToList();

            // Generate frequent itemsets
            List<List<string>> frequentItemsets = new List<List<string>>();
            List<List<string>> candidateItemsets = GenerateInitialCandidateItemsets(uniqueItems);

            while (candidateItemsets.Any())
            {
                // Calculate support for candidate itemsets
                Dictionary<List<string>, int> candidateItemsetSupport = new Dictionary<List<string>, int>();
                foreach (List<string> transaction in transactions)
                {
                    foreach (List<string> candidateItemset in candidateItemsets)
                    {
                        if (candidateItemset.All(item => transaction.Contains(item)))
                        {
                            if (!candidateItemsetSupport.ContainsKey(candidateItemset))
                            {
                                candidateItemsetSupport[candidateItemset] = 0;
                            }
                            candidateItemsetSupport[candidateItemset]++;
                        }
                    }
                }

                // Add frequent itemsets to results
                frequentItemsets.AddRange(candidateItemsetSupport.Where(x => x.Value >= minSupport).Select(x => x.Key));

                // Generate new candidate itemsets
                candidateItemsets = GenerateCandidateItemsets(candidateItemsetSupport.Where(x => x.Value >= minSupport).Select(x => x.Key).ToList());

            }

            return frequentItemsets;
        }

        static List<List<string>> GenerateInitialCandidateItemsets(List<string> uniqueItems)
        {
            List<List<string>> candidateItemsets = new List<List<string>>();
            foreach (string item in uniqueItems)
            {
                candidateItemsets.Add(new List<string> { item });
            }
            return candidateItemsets;
        }

        static List<List<string>> GenerateCandidateItemsets(List<List<string>> frequentItemsets)
        {
            List<List<string>> candidateItemsets = new List<List<string>>();
            for (int i = 0; i < frequentItemsets.Count; i++)
            {
                for (int j = i + 1; j < frequentItemsets.Count; j++)
                {
                    if (frequentItemsets[i].Take(frequentItemsets[i].Count - 1).SequenceEqual(frequentItemsets[j].Take(frequentItemsets[j].Count - 1)))
                    {
                        candidateItemsets.Add(frequentItemsets[i].Union(frequentItemsets[j]).ToList());
                    }
                }
            }
            return candidateItemsets;
        }

        private void Get_Click(object sender, EventArgs e)
        {

        }


        private void addField_Click(object sender, EventArgs e)
        {
            TextBox txtRun = new TextBox();
            txtRun.Location = new Point(134, y);
            txtRun.Name = "txtDynamic";
            this.Controls.Add(txtRun);
            y += txtRun.Height + 7;
            txtRun.Size = new System.Drawing.Size(228, 27);
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            List<string> Menu = new List<string>();

            foreach (var text in this.Controls)
            {
                var textBox = text as TextBox;
                if (textBox != null)
                {
                    Menu = textBox.Text.Split(", ").ToList();
                    transactions.Add(Menu);
                    //Menu.Clear();
                }
            }
        }

        private void getResultBtn_Click(object sender, EventArgs e)
        {
            List<List<string>> frequentItemsets = AprioriAlgorithm(transactions, minSupport);
            List<List<string>> print = new List<List<string>>();
            foreach (List<string> itemset in frequentItemsets)
            {
                List<string> list = new List<string>();
                foreach (var subitem in itemset)
                {
                    list.Add(subitem);
                }
                print.Add(list);
            }
            Form2 form2 = new Form2(print);
            form2.ShowDialog();
        }
    }
}