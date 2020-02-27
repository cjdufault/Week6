using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private readonly SortedList<string, bool> Questions = new SortedList<string, bool>()
        {
            { "SSDs are faster than HDDs", true },
            { "Microsoft owns Github", true },
            { "100 is the ASCII code for \"A\"", false }
        };
        private int QuestionNumber = -1;
        private int Score = 0;

        public Form1()
        {
            InitializeComponent();
            ShowNextQuestion(); // show the 1st question
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (rdoTrue.Checked || rdoFalse.Checked)
            {
                CheckAnswer();
                ShowNextQuestion();
            }
        }

        // advances to the next question, and ends the game if questions are exhausted
        private void ShowNextQuestion()
        {
            QuestionNumber++;

            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber);
                string questionText = question.Key;
                txtQuestion.Text = questionText;

                rdoTrue.Checked = false;
                rdoFalse.Checked = false;
            }
            else
            {
                btnCheckAnswer.Enabled = false;
                btnCheckAnswer.Text = "Quiz over!";
                MessageBox.Show($"Your score is {Score}", "Quiz over!");
                this.Dispose();
            }
        }

        private void CheckAnswer()
        {
            if (QuestionNumber < Questions.Count)
            {
                KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber);
                bool correctAnswer = question.Value;

                // compare the answer to the radio button that has been clicked
                if (correctAnswer == true & rdoTrue.Checked == true)
                {
                    Score++;
                }
                if (correctAnswer == false & rdoFalse.Checked == true)
                {
                    Score++;
                }

                lblScore.Text = $"Score: {Score}";
            }
        }
    }
}
