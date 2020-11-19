﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactorialCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Factorial();
            Permutations();
            Combinations();

        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }


        public void Permutations()
        {
            //TODO: Write Formulate to out put the permutation of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem. 
            Double N;
            Double n = 1;
            Double R;
            Double r = 1;
            Double perm;
            Double nr = 1;

            N = Convert.ToInt32(xNObjects.Text);
            R = Convert.ToInt32(xRSample.Text);
            Double NR = N - R;

            for (int x = 1; x <= N; x++)
            {
                n = n * x;
            }

            for (int x = 1; x <= R; x++)
            {
                r = r * x;
            }

            for (int x = 1; x <= NR; x++)
            {
                nr = nr * x;
            }

            perm = n / nr;

            xPermutationAnswer.Text = Convert.ToString(perm);
        }

        public void Combinations()
        {
            //TODO: Write Formulate to out put the permutation of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem.

            double n = 0;
            double nFact = 0;
            double r = 0;
            double rFact = 0;

            Double.TryParse(xNObjects.Text, out n);
            Double.TryParse(xRSample.Text, out r);

            double nMinusR = -r;
            double nMinusRFact = 1;

            for (int x = 1; x <= n; x++)
            {
                nFact = nFact * x;
            }

            for (int x = 1; x <= r; x++)
            {
                rFact = rFact * x;
            }

            for (int x = 1; x <= nMinusR; x++)
            {
                nMinusRFact = nMinusRFact * x;
            }

            double combinationAnswer = nFact / (rFact * nMinusRFact);

            xCombinationAnswer.Text = combinationAnswer.ToString();
        }


        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
