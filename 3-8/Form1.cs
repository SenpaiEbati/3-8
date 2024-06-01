using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_8
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private void Search_B_Click(object sender, EventArgs e)
        {
            
            string pattern = Pattern_TB.Text;
            string email;
            if (string.IsNullOrWhiteSpace(pattern))
            {
                // Поиск всех почтовых адресов
                email = @"\b[A-Za-z][A-Za-z0-9._%+-]*@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            }
            else
            {
                // Поиск почтовых адресов по паттерну
                email = $@"\b[A-Za-z][A-Za-z0-9._%+-]*@[A-Za-z0-9.-]+\.{pattern}\b";
            }

            MatchCollection res = Regex.Matches(Source_TB.Text, email);

            Result_TB.Clear();

            if (res.Count == 0)
                Result_TB.AppendText("Нет совпадений");
            else
                foreach (Match m in res)
                    Result_TB.AppendText(m.Value + Environment.NewLine);
        }

        private void Replace_B_Click(object sender, EventArgs e)
        {
            string email = @"\b[A-Za-z][A-Za-z0-9._%+-]*@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            string resultText = Regex.Replace(Source_TB.Text, email, match =>
            {
                string em = match.Value;

                int atindex = em.IndexOf('@');
                int dotindex = em.LastIndexOf('.');

                if (atindex < 0 || dotindex < atindex)
                {
                    return em;
                }

                string beforeat = em.Substring(0, atindex);
                string afterat = em.Substring(atindex + 1);

                return $"{beforeat.Length}@{afterat.Length}";
            });

            Result_TB.Clear();
            if (resultText.Count() == 0)
                Result_TB.AppendText("Нет совпадений");
            else
                Result_TB.Text = resultText;
        }
        /*Тестовые email: alice@wonderland.net, bob@builder.co.uk.
Некоторые недействительные: charlie@domain., dave@domain..com, eve@.domain.com.
Особый случай: frank@sub.domain.org, george@another-domain.com.
        */
    }
}
